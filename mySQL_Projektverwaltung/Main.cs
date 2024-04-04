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

namespace mySQL_Projektverwaltung
{
    public partial class Main : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int id;
        bool isDoubleClick = false;
        String connectString;

        public Main()
        {
            InitializeComponent();
            //connectString = @"Data Source=" + Application.StartupPath + @"\Database\crud.db;version=3";
            connectString = @"Data Source=C:\Users\faesc\Desktop\Projekmanagement_App\projekt.db;version=3";

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
                String sql = "SELECT * FROM projTime";
                adapter = new SQLiteDataAdapter(sql, conn);
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
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

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
                    conn = new SQLiteConnection(connectString);
                    conn.Open();
                    cmd = new SQLiteCommand();
                    cmd.CommandText = @"DELETE FROM projTime WHERE ID='" + id + "'";
                    cmd.Connection = conn;
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Deleted!");
                        id = 0;
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

        private void GetIdToDelete_DGVprojHours(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            isDoubleClick = false;
        }
    }
}
