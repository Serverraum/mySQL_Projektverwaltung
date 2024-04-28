using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung
{
    public partial class Project_TimeControl : UserControl
    {
        public int projID;
        public Project_TimeControl()//int projId)
        {
            projID = 0;// projId;
            InitializeComponent();
        }
        public void ReLoad_Project_TimeControl(int projId)
        {
            if (this.dataGridView1.AllowUserToAddRows == false)
            {
                this.dataGridView1.AllowUserToAddRows = true;
            }
            projID = projId;
            ReadDataProjHours();
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
                        DbConnParam.DbConn.Instance.DbAddCmd("");
                        string sql = @"INSERT INTO projTime (date, description, time_h, ProjID, LSID, AGID) VALUES (@date, @description, @time_h, @projID, 1, 1)";
                        DbConnParam.DbConn.Instance.DbAddCmd(sql);
                        string currentDateTimeString = DateTime.Now.ToString("s");
                        DbConnParam.DbConn.Instance.CmdAddParam("@date", currentDateTimeString);//dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        DbConnParam.DbConn.Instance.CmdAddParam("@description", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        DbConnParam.DbConn.Instance.CmdAddParam("@time_h", dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                        int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Successfully Updated!");
                            ReadDataProjHours();
                            dataGridView1.ClearSelection();
                            dataGridView1.CurrentCell = null;
                        }
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

        private void DGV_Update(object sender, DataGridViewCellEventArgs e) // Update Zeile von DataGridView in Datenbank
        {
            try
            {
                string sql = @"UPDATE projTime set date=@date, description=@description, time_h=@time_h WHERE ID=@id";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                string dateString = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DateTime date;
                if (DateTime.TryParse(dateString, out date))
                {
                    // Konvertiere das Datum in das "s"-Format /sortierbare Form/
                    string formattedDate = date.ToString("s");
                    DbConnParam.DbConn.Instance.CmdAddParam("@date", formattedDate);
                } //Fill Datum
                else
                {
                    // Handle den Fall, wenn das Parsen fehlschlägt
                    // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                    throw new Exception("Ungültiges Datumsformat in Zeile " + (e.RowIndex + 1));
                }
                DbConnParam.DbConn.Instance.CmdAddParam("@description", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                DbConnParam.DbConn.Instance.CmdAddParam("@time_h", dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                    ReadDataProjHours();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVprojHours_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) //DataGridView Key:"Entf"
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string sql = @"DELETE FROM projTime WHERE ID= $id ";
                    DbConnParam.DbConn.Instance.DbAddCmd(sql);
                    DbConnParam.DbConn.Instance.CmdAddParam("$id", Convert.ToInt32(e.Row.Cells[0].Value));
                    int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Deleted!");
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = null;
                    }
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

        private void ReadDataProjHours()
        {
            try
            {
                dataGridView1.DataSource = null;
                string sql = "SELECT * FROM projTime WHERE projID=" + projID;
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

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
                        MessageBox.Show("Date wrong: '" + row[1].ToString() + "' not in Format of dd.mm.yy");

                        // Handle den Fall, wenn das Parsen fehlschlägt
                        // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                    }
                }


                dataGridView1.DataSource = dt;
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

        private void DGV_Update(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentRowDirty)
            {
                MessageBox.Show("Dirty");
            }
            else { MessageBox.Show("Clean"); }
        }
    }
}
