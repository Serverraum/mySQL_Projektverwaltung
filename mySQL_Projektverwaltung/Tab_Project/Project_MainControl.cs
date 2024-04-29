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
using static mySQL_Projektverwaltung.Main;

namespace mySQL_Projektverwaltung.Tab_Project
{
    public partial class Project_MainControl : UserControl
    {
        public int projID = 0;
        private Main main;
        private ProjAuswahl projAuswahl;
        DataTable dtProj = new DataTable();
        public Project_MainControl()
        {
            InitializeComponent();
        }
        public void ReLoad_Project_MainControl(int projId)
        {
            projID = projId;
            if (editProj.Checked)
            {
                editProj.Checked = false;
            }
            if (bt_proj_save.Enabled == true)
            {
                bt_proj_save.Enabled = false;
            }
            ReadDataProj(projID);
        }

        private void ReadDataProj(int projID)
        {
            //cmd.CommandText = @"INSERT INTO projTime (date, description, time_h, ProjID, LSID, AGID) VALUES (@date, @description, @time_h, @projID, 1, 1)";
            try
            {

                String sql = @"SELECT * FROM proj WHERE projID = @projID";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                dtProj = DbConnParam.DbConn.Instance.DbGetDataTable();

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

                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@endDate", dtProj.Rows[0][1].ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@startDate", dtProj.Rows[0][1].ToString());
                cb_LS.Items.Clear();
                int i = 0;


                DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
                foreach (DataRow dr in dt.Rows)
                {
                    cb_LS.Items.Add(dr[1].ToString());
                    if (dtProj.Rows[0][2].ToString() == dr[0].ToString())
                    {
                        cb_LS.SelectedIndex = i;
                    }
                    i++;
                }


                sql = "SELECT * FROM ag WHERE datecreated < @startDate AND (dateremoved > @endDate OR dateremoved IS NULL) AND LSID=@LSID"; //dtProj.Rows[0][1] => Projekt-Erstelldatum im ISO861-Format
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@startDate", dtProj.Rows[0][1].ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@endDate", dtProj.Rows[0][1].ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@LSID", dtProj.Rows[0][2].ToString());
                cb_AG.Items.Clear();
                i = 0;
                dt = DbConnParam.DbConn.Instance.DbGetDataTable();
                foreach (DataRow dr in dt.Rows)
                {
                    cb_AG.Items.Add(dr[2].ToString());
                    if (dtProj.Rows[0][3].ToString() == dr[0].ToString())
                    {
                        cb_AG.SelectedIndex = i;

                    }
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void tb_shortdesc_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)
            {
                bt_proj_save.Enabled = true;
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
        private void bt_proj_save_Click(object sender, EventArgs e)
        {
            bt_proj_save.Enabled = false;
            try
            {
                string sql = @"SELECT LSID FROM ls WHERE LS=@LS";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@LS", cb_LS.SelectedItem.ToString());
                string LSID = DbConnParam.DbConn.Instance.DbScalar().ToString();

                sql = @"SELECT AGID FROM ag WHERE AG=@AG";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@AG", cb_AG.SelectedItem.ToString());
                string AGID = DbConnParam.DbConn.Instance.DbScalar().ToString();

                sql = @"UPDATE proj set date=@date, LSID=@LSID, AGID=@AGID, name=@name, email=@email, tel=@tel, desc_short=@desc_short WHERE ProjID= @id";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@id", projID);


                string dateString = mtb_date.Text.ToString();
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
                    throw new Exception("Ungültiges Datumsformat");
                }
                DbConnParam.DbConn.Instance.CmdAddParam("@LSID", LSID); // cb_LS.SelectedItem.ToString()=> "Lanz"
                DbConnParam.DbConn.Instance.CmdAddParam("@AGID", AGID);
                DbConnParam.DbConn.Instance.CmdAddParam("@name", tb_name.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@email", tb_email.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@tel", tb_tel.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@desc_short", tb_shortdesc.Text.ToString());
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    //update windows

                    foreach (var item in Application.OpenForms)
                    {
                        ProjAuswahl projAuswahl = item as ProjAuswahl;
                        if (projAuswahl != null)
                        {
                            projAuswahl.UpdateSurface();
                        }
                    }
                    foreach (var item in Application.OpenForms)
                    {
                        Main main = item as Main;
                        if (main != null)
                        {
                            main.LoadProject(projID);
                        }
                    }
                    
                }
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
            string sql = @"SELECT LSID FROM ls WHERE LS=@LS";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@LS", cb_LS.SelectedItem.ToString());
            string LSID = DbConnParam.DbConn.Instance.DbScalar().ToString(); ; //get LSID from name, da cb_LS keine Tags unterstützt

            sql = "SELECT * FROM ag WHERE datecreated < @startDate AND (dateremoved > @endDate OR dateremoved IS NULL) AND LSID=@LSID"; //dtProj.Rows[0][1] => Projekt-Erstelldatum im ISO861-Format
            DbConnParam.DbConn.Instance.DbAddCmd(sql);

            string dateString = mtb_date.Text.ToString();
            DateTime date;
            if (DateTime.TryParse(dateString, out date))
            {
                // Konvertiere das Datum in das "s"-Format /sortierbare Form/
                string formattedDate = date.ToString("s");
                DbConnParam.DbConn.Instance.CmdAddParam("@startDate", formattedDate);
                DbConnParam.DbConn.Instance.CmdAddParam("@endDate", formattedDate);
            } //Fill Datum
            else
            {
                // Handle den Fall, wenn das Parsen fehlschlägt
                // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                throw new Exception("Ungültiges Datumsformat");
            }
            DbConnParam.DbConn.Instance.CmdAddParam("@LSID", LSID);
            cb_AG.Items.Clear();
            DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
            int i = 0;
            foreach (DataRow dr in dt.Rows) {
                cb_AG.Items.Add(dr[2].ToString());
                if (dtProj.Rows[0][3].ToString() == dr[0].ToString())
                {
                    cb_AG.SelectedIndex = i;

                }
                i++;
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
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



    }
}
