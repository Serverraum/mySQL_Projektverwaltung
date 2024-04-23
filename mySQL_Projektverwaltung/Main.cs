using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Media.Media3D;
using System.Globalization;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;


namespace mySQL_Projektverwaltung
{


    public partial class Main : Form
    {
        ReadTest robertzeigtmirwas = new ReadTest();
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataSet ds = new DataSet();
        DataSet dsProj = new DataSet();
        DataSet dsLS = new DataSet();
        DataSet dsAG = new DataSet();
        DataTable dt = new DataTable();
        DataTable dtProj = new DataTable();
        DataTable dtLS = new DataTable();
        DataTable dtAG = new DataTable();
        bool isDoubleClick = false;
        public String connectString;
        int projID = 0;
        int i;
        public Boolean ProjLoad;
        private ProjAuswahl projAuswahl;
        private string filePath = @"C:/";
        private bool isFile = false;
        private string currentlySelectedItemName = "";

        public Main()
        {
            InitializeComponent();
            DbConnParam.DbConn.Instance.connLoadParam();

            //connectString = @"Data Source=" + Application.StartupPath + @"\Database\crud.db;version=3";
            connectString = @"Data Source=C:\Users\faesc\Desktop\Projekmanagement_App\projekt.db;version=3";


            // Versuche, die Konfigurationsdatei zu laden; Can be removed


            tb_DB_File.Text = connectString.Substring(12, connectString.Length - 22);

        }

        private void ProjAuswahl_TreeNodeClicked(object sender, TreeNodeClickedEventArgs e)
        {
            TreeNode clickedNode = e.ClickedNode;
            // Hier kannst du den geklickten Knoten verwenden, z. B.:
            //MessageBox.Show($"Knoten '{clickedNode.Text}' wurde in Form1 geklickt.'{clickedNode.Tag}' ");
            if (clickedNode.Tag != null)
            {
                this.BringToFront();
                ProjLoad = true;
                //MessageBox.Show(clickedNode.Tag.ToString());
                projID = Convert.ToInt32(clickedNode.Tag);
                if (this.dataGridView1.AllowUserToAddRows == false)
                {
                    this.dataGridView1.AllowUserToAddRows = true;
                }
                if (editProj.Checked == true)
                {
                    editProj.Checked = false;
                }
                if (bt_proj_save.Enabled == true)
                {
                    bt_proj_save.Enabled = false;
                }
                ReadDataProjHours();
                ReadDataProj();

                ProjLoad = false;

                tb_DB_File.Text = DbConnParam.DbConn.Instance.connParamGetSQLite();
            }
        }

        private void ReadDataProj()
        {
            //cmd.CommandText = @"INSERT INTO projTime (date, description, time_h, ProjID, LSID, AGID) VALUES (@date, @description, @time_h, @projID, 1, 1)";
            try
            {
                conn = new SQLiteConnection(connectString);
                conn.Open();
                cmd = new SQLiteCommand();
                String sql = "SELECT * FROM proj WHERE projID=" + projID;
                adapter = new SQLiteDataAdapter(sql, conn);
                dsProj.Reset();
                adapter.Fill(dsProj);
                dtProj = dsProj.Tables[0];

                tb_name.Text = dtProj.Rows[0][4].ToString();
                tb_tel.Text = dtProj.Rows[0][5].ToString();
                tb_email.Text = dtProj.Rows[0][6].ToString();

                DateTime date;
                if (DateTime.TryParseExact(dtProj.Rows[0][1].ToString(), "s", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    // Konvertiere das Datum in das ShortDateString-Format
                    mtb_date.Text = date.ToShortDateString();

                }
                else
                {
                    mtb_date.Text = "";
                }
                mtb_date.Text = date.ToShortDateString();//dtProj.Rows[0][1].ToString();
                tb_shortdesc.Text = dtProj.Rows[0][7].ToString();

                sql = "SELECT * FROM ls WHERE datecreated < @endDate AND (dateremoved > @startDate OR dateremoved IS NULL)";
                //sql = "SELECT * FROM ls WHERE datecreated < '" + dtProj.Rows[0][1] + "' AND (dateremoved > '" + dtProj.Rows[0][1] + "' OR dateremoved IS NULL)"; //dtProj.Rows[0][1] => Projekt-Erstelldatum im ISO861-Format

                cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@endDate", dtProj.Rows[0][1].ToString());
                cmd.Parameters.AddWithValue("@startDate", dtProj.Rows[0][1].ToString());
                cb_LS.Items.Clear();
                i = 0;
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cb_LS.Items.Add(reader.GetValue(1).ToString());
                        if (dtProj.Rows[0][2].ToString() == reader.GetValue(0).ToString())
                        {
                            cb_LS.SelectedIndex = i;

                        }
                        i++;
                    }
                }

                sql = "SELECT * FROM ag WHERE datecreated < @startDate AND (dateremoved > @endDate OR dateremoved IS NULL) AND LSID=@LSID"; //dtProj.Rows[0][1] => Projekt-Erstelldatum im ISO861-Format

                cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@startDate", dtProj.Rows[0][1].ToString());
                cmd.Parameters.AddWithValue("@endDate", dtProj.Rows[0][1].ToString());
                cmd.Parameters.AddWithValue("@LSID", dtProj.Rows[0][2].ToString());
                cb_AG.Items.Clear();
                i = 0;
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cb_AG.Items.Add(reader.GetValue(2).ToString());
                        if (dtProj.Rows[0][3].ToString() == reader.GetValue(0).ToString())
                        {
                            cb_AG.SelectedIndex = i;

                        }
                        i++;
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ReadDataProjHours(); //Arbeitsstunden für individuelles Projekt darstellen
        }

        private void ReadDataProjHours()
        {
            try
            {
                conn = new SQLiteConnection(connectString);
                conn.Open();
                cmd = new SQLiteCommand();
                String sql = "SET IDENTITY_INSERT projTime OFF;";
                adapter = new SQLiteDataAdapter(sql, conn);
                sql = "SELECT * FROM projTime WHERE projID=" + projID;
                adapter = new SQLiteDataAdapter(sql, conn);
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];


                // Konvertiere das Datum in der ersten Spalte in das ShortDateString-Format
                foreach (DataRow row in dt.Rows)
                {
                    // Annahme: Das Datum liegt in der ersten Spalte (Index 0)
                    string dateString = row[1].ToString(); // Hole das Datum als String aus der DataRow

                    // Parsen des Datums in das DateTime-Objekt
                    DateTime date;
                    if (DateTime.TryParseExact(dateString, "s", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        // Konvertiere das Datum in das ShortDateString-Format
                        string shortDateString = date.ToShortDateString();

                        // Setze das konvertierte Datum zurück in die erste Spalte der DataRow
                        row[1] = shortDateString;
                    }
                    else
                    {
                        // Handle den Fall, wenn das Parsen fehlschlägt
                        // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                    }
                }


                dataGridView1.DataSource = dt;
                conn.Close();
                dataGridView1.Columns[1].HeaderText = "Datum";
                dataGridView1.Columns[2].HeaderText = "Beschreibung";
                dataGridView1.Columns[3].HeaderText = "Zeit";
                dataGridView1.Columns[0].Visible = false; //ID von projTime
                dataGridView1.Columns[4].Visible = false; //projID
                dataGridView1.Columns[5].Visible = false; //LSID
                dataGridView1.Columns[6].Visible = false; //AGID
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)
            {
                bt_proj_save.Enabled = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = SumColumn(dataGridView1, 3).ToString();
        }

        private decimal SumColumn(DataGridView dgv, int columnIndex)
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            return sum;
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVprojHours_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) //DataGridView Key:"Entf"
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //conn = new SQLiteConnection(connectString);
                    conn.Open();
                    cmd = new SQLiteCommand();
                    cmd.CommandText = @"DELETE FROM projTime WHERE ID= $id ";
                    cmd.Parameters.AddWithValue("$id", Convert.ToInt32(e.Row.Cells[0].Value));
                    cmd.Connection = conn;
                    i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Deleted!");
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = null;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }


        private void label1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            projAuswahl = new ProjAuswahl();
            projAuswahl.TreeNodeClicked += ProjAuswahl_TreeNodeClicked;
            projAuswahl.Show();

        }


        private void DGV_Update(object sender, DataGridViewCellEventArgs e) // Update Zeile von DataGridView in Datenbank
        {
            try
            {
                conn.Open();
                cmd = new SQLiteCommand();
                cmd.CommandText = @"UPDATE projTime set date=@date, description=@description, time_h=@time_h WHERE ID= $id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("$id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                string dateString = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DateTime date;
                if (DateTime.TryParse(dateString, out date))
                {
                    // Konvertiere das Datum in das "s"-Format /sortierbare Form/
                    string formattedDate = date.ToString("s");
                    cmd.Parameters.AddWithValue("@date", formattedDate);
                } //Fill Datum
                else
                {
                    // Handle den Fall, wenn das Parsen fehlschlägt
                    // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                    throw new Exception("Ungültiges Datumsformat in Zeile " + (e.RowIndex + 1));
                }
                cmd.Parameters.AddWithValue("@description", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                cmd.Parameters.AddWithValue("@time_h", dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    ReadDataProjHours();
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                    isDoubleClick = false;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewRow_DGVprojHours(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (e.RowIndex == dataGridView1.Rows.Count - 1)// && e.ColumnIndex == dataGridView1.Columns.Count - 1)
                {
                    // Einen neuen Datensatz hinzufügen
                    MessageBox.Show("Neuer Eintrag");
                    try
                    {
                        conn.Open();
                        cmd = new SQLiteCommand();
                        cmd.CommandText = @"INSERT INTO projTime (date, description, time_h, ProjID, LSID, AGID) VALUES (@date, @description, @time_h, @projID, 1, 1)";
                        cmd.Connection = conn;
                        string currentDateTimeString = DateTime.Now.ToString("s");
                        cmd.Parameters.AddWithValue("@date", currentDateTimeString);//dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@description", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@time_h", dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@projID", projID);
                        int i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Successfully Updated!");
                            ReadDataProjHours();
                            dataGridView1.ClearSelection();
                            dataGridView1.CurrentCell = null;
                            isDoubleClick = false;
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    // DataRow newRow = dataSet.Tables["YourTable"].NewRow();
                    // dataSet.Tables["YourTable"].Rows.Add(newRow);

                    // DataGridView aktualisieren
                    //dataGridView1.Refresh();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //ToDo: NewLine oder empty
                MessageBox.Show("Argument out of Range; DataGridView1. TODO NEWLINE ODER EMPTY");
            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("InvalidCastException;DataGridView1. DBNull");
            }

        }

        private void editProj_CheckedChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)
            {
                cb_LS.Enabled = true;
                cb_AG.Enabled = true;
                tb_name.Enabled = true;
                tb_tel.Enabled = true;
                tb_email.Enabled = true;
                mtb_date.Enabled = true;
                tb_shortdesc.Enabled = true;
            }
            else
            {
                cb_LS.Enabled = false;
                cb_AG.Enabled = false;
                tb_name.Enabled = false;
                tb_tel.Enabled = false;
                tb_email.Enabled = false;
                mtb_date.Enabled = false;
                tb_shortdesc.Enabled = false;
            }
        }


        private void bt_proj_save_MouseClick(object sender, MouseEventArgs e)
        {
            bt_proj_save.Enabled = false;
            try
            {
                conn.Open();

                cmd = new SQLiteCommand();
                cmd.CommandText = @"SELECT LSID FROM ls WHERE LS=@LS";
                cmd.Parameters.AddWithValue("@LS", cb_LS.SelectedItem.ToString());
                cmd.Connection = conn;
                string LSID = cmd.ExecuteScalar().ToString();

                cmd = new SQLiteCommand();
                cmd.CommandText = @"SELECT AGID FROM ag WHERE AG=@AG";
                cmd.Parameters.AddWithValue("@AG", cb_AG.SelectedItem.ToString());
                cmd.Connection = conn;
                string AGID = cmd.ExecuteScalar().ToString();

                cmd = new SQLiteCommand();
                cmd.CommandText = @"UPDATE proj set date=@date, LSID=@LSID, AGID=@AGID, name=@name, email=@email, tel=@tel, desc_short=@desc_short WHERE ProjID= $id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("$id", projID);


                string dateString = mtb_date.Text.ToString();
                DateTime date;
                if (DateTime.TryParse(dateString, out date))
                {
                    // Konvertiere das Datum in das "s"-Format /sortierbare Form/
                    string formattedDate = date.ToString("s");
                    cmd.Parameters.AddWithValue("@date", formattedDate);
                } //Fill Datum
                else
                {
                    // Handle den Fall, wenn das Parsen fehlschlägt
                    // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                    throw new Exception("Ungültiges Datumsformat");
                }
                cmd.Parameters.AddWithValue("@LSID", LSID); // cb_LS.SelectedItem.ToString()=> "Lanz"
                cmd.Parameters.AddWithValue("@AGID", AGID);
                cmd.Parameters.AddWithValue("@name", tb_name.Text.ToString());
                cmd.Parameters.AddWithValue("@email", tb_email.Text.ToString());
                cmd.Parameters.AddWithValue("@tel", tb_tel.Text.ToString());
                cmd.Parameters.AddWithValue("@desc_short", tb_shortdesc.Text.ToString());
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    //update windows
                    ReadDataProjHours();
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                    isDoubleClick = false;

                    projAuswahl.UpdateSurface();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cb_AG_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
        }

        private void cb_LS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }

            conn.Open();
            cmd = new SQLiteCommand();
            cmd.CommandText = @"SELECT LSID FROM ls WHERE LS=@LS";
            cmd.Parameters.AddWithValue("@LS", cb_LS.SelectedItem.ToString());
            cmd.Connection = conn;
            string LSID = cmd.ExecuteScalar().ToString(); //get LSID from name, da cb_LS keine Tags unterstützt

            String sql = "SELECT * FROM ag WHERE datecreated < @startDate AND (dateremoved > @endDate OR dateremoved IS NULL) AND LSID=@LSID"; //dtProj.Rows[0][1] => Projekt-Erstelldatum im ISO861-Format

            cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            string dateString = mtb_date.Text.ToString();
            DateTime date;
            if (DateTime.TryParse(dateString, out date))
            {
                // Konvertiere das Datum in das "s"-Format /sortierbare Form/
                string formattedDate = date.ToString("s");
                cmd.Parameters.AddWithValue("@startDate", formattedDate);
                cmd.Parameters.AddWithValue("@endDate", formattedDate);
            } //Fill Datum
            else
            {
                // Handle den Fall, wenn das Parsen fehlschlägt
                // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                throw new Exception("Ungültiges Datumsformat");
            }
            cmd.Parameters.AddWithValue("@LSID", LSID);
            cb_AG.Items.Clear();
            i = 0;
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    cb_AG.Items.Add(reader.GetValue(2).ToString());
                    if (dtProj.Rows[0][3].ToString() == reader.GetValue(0).ToString())
                    {
                        cb_AG.SelectedIndex = i;

                    }
                    i++;
                }
            }
            conn.Close();


        }

        private void tb_tel_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
        }

        private void mtb_date_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
        }

        private void tb_shortdesc_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 7);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 9);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                        }

                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 10);
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }

        private void Button_SetDB_Click(object sender, EventArgs e)
        {
            label8.Text = this.currentlySelectedItemName;
        }
    }
}
