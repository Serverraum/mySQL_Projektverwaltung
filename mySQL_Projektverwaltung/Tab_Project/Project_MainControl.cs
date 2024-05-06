using Google.Protobuf;
using mySQL_Projektverwaltung;
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
using System.Windows.Media;
using static mySQL_Projektverwaltung.Main;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
//  Hard Connection to/from:                 //
//   - Desc_long (project_DetailsControl1)   //
//   - Folder    (project_FolderControl1)    //
//   (Both for Save-Function)                //
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

namespace mySQL_Projektverwaltung.Tab_Project
{
    public partial class Project_MainControl : UserControl
    {
        public int projID = 0;
        DataTable dtProj = new DataTable();
        public Project_MainControl()
        {
            InitializeComponent();
        }
        public void ReLoad_Project_MainControl(int projId)
        {
            projID = projId;
            /*Enable Items after first Project has been loaded*/
            if (editProj.Checked)
            {
                editProj.Checked = false;
            }
            /**/
            if (bt_proj_save.Enabled == true)
            {
                bt_proj_save.Enabled = false;
            }

            ReadDataProj(projID);
        }
        bool completed;
        private void ReadDataProj(int projID)
        {
            //cmd.CommandText = @"INSERT INTO projTime (date, description, time_h, ProjID, LSID, AGID) VALUES (@date, @description, @time_h, @projID, 1, 1)";
            try
            {

                String sql = @"SELECT * FROM proj WHERE projID = @projID";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                dtProj = DbConnParam.DbConn.Instance.DbGetDataTable();
                string projDate = dtProj.Rows[0][1].ToString();
                string projLSID = dtProj.Rows[0][2].ToString();
                string projAGID = dtProj.Rows[0][3].ToString();
                tb_name.Text = dtProj.Rows[0][4].ToString();
                tb_tel.Text = dtProj.Rows[0][5].ToString();
                tb_email.Text = dtProj.Rows[0][6].ToString();
                tb_shortdesc.Text = dtProj.Rows[0][7].ToString();
                string textlong = dtProj.Rows[0][8].ToString(); //-ext. Load
                string completed_str = dtProj.Rows[0][9].ToString();
                //string folder = dtProj.Rows[0][10].ToString(); //-ext. Load, not yet implemented

                /* -- Prepare UI -- */

                /*------ Set Completed-Button ------*/
                if (completed_str == "1") { completed = true; } else { completed = false; };
                bt_completed_change(completed);

                /*------ Set Date ------*/
                mtb_date.Text = iso8601ToDate(projDate);//dtProj.Rows[0][1].ToString();


                /*------ Set combobox_LS ------*/
                sql = "SELECT * FROM ls WHERE datecreated < @endDate AND (dateremoved > @startDate OR dateremoved IS NULL)";
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

                /*------ Set combobox_AG ------*/
                cb_AG_Refill(projDate, projLSID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveStateChanged() {
            bt_proj_save.Enabled = true;
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
            bt_completed.Enabled = editProj.Checked;
            cb_LS.Enabled = editProj.Checked;
            tb_name.Enabled = editProj.Checked;
            tb_tel.Enabled = editProj.Checked;
            tb_email.Enabled = editProj.Checked;
            mtb_date.Enabled = editProj.Checked;
            tb_shortdesc.Enabled = editProj.Checked;
        }
        private void bt_proj_save_Click(object sender, EventArgs e) //Save Function
        {
            bt_proj_save.Enabled = false;
            try
            {
                /*Get LSID from LS name*/
                string sql = @"SELECT LSID FROM ls WHERE LS=@LS";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@LS", cb_LS.SelectedItem.ToString());
                string LSID = DbConnParam.DbConn.Instance.DbScalar().ToString();

                /*Get AGID from AG name*/
                sql = @"SELECT AGID FROM ag WHERE AG=@AG";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@AG", cb_AG.SelectedItem.ToString());
                string AGID = DbConnParam.DbConn.Instance.DbScalar().ToString();

                /*------ Prepare Commit ------*/
                sql = @"UPDATE proj set date=@date, LSID=@LSID, AGID=@AGID, name=@name, email=@email, tel=@tel, desc_short=@desc_short, desc_long=@desc_long, completed=@completed WHERE ProjID= @id";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@id", projID);


                /*Poll desc_long*/
                string desc_long = "";
                foreach (var item in Application.OpenForms)
                {
                    Main main = item as Main;
                    if (main != null)
                    {
                       desc_long = main.project_DetailsControl1.Save_Project_DetailsControl();
                    }
                }
                
                // Save_Project_DetailsControl
                /*Poll folder, not yet implemented*/

                /*------ Add Params ------*/
                string dateString = mtb_date.Text.ToString();
                string iso8601 = dateToIso8601(dateString);
                DbConnParam.DbConn.Instance.CmdAddParam("@date", iso8601);
                DbConnParam.DbConn.Instance.CmdAddParam("@LSID", LSID); // cb_LS.SelectedItem.ToString()=> "Lanz"
                DbConnParam.DbConn.Instance.CmdAddParam("@AGID", AGID);
                DbConnParam.DbConn.Instance.CmdAddParam("@name", tb_name.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@email", tb_email.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@tel", tb_tel.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@desc_long", desc_long);
                DbConnParam.DbConn.Instance.CmdAddParam("@desc_short", tb_shortdesc.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@completed", completed);
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    //update windows
                    /*------ Reload projAuswahl-Windows ------*/
                    foreach (var item in Application.OpenForms)
                    {
                        ProjAuswahl projAuswahl = item as ProjAuswahl;
                        if (projAuswahl != null)
                        {
                            projAuswahl.UpdateSurface();
                        }
                    }
                    /*------ Reload Main Project Page ------*/
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
            /*Enable Save-Button*/
            if (editProj.Checked == true)//&& cb_LS.SelectedItem.ToString() == "LS ()")
            {
                bt_proj_save.Enabled = true;
            }
            /*Get LSID from Database*/
            /*'LS Parodi' --> LSID=3 */
            string sql = @"SELECT LSID FROM ls WHERE LS=@LS";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@LS", cb_LS.SelectedItem.ToString());
            string LSID = DbConnParam.DbConn.Instance.DbScalar().ToString(); ; //get LSID from name, da cb_LS keine Tags unterstützt


            string dateString = mtb_date.Text.ToString();
            cb_AG_Refill(dateString, LSID);
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


        private void cb_AG_Refill(string projDate, string LSID)//Refill Function used by my other functions
        {
            try
            {
                /*------ Refill comboBox AG ------*/
                string sql = "SELECT * FROM ag WHERE datecreated < @startDate AND (dateremoved > @endDate OR dateremoved IS NULL) AND LSID=@LSID"; //dtProj.Rows[0][1] => Projekt-Erstelldatum im ISO8601-Format
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                string iso8601 = dateToIso8601(projDate);
                DbConnParam.DbConn.Instance.CmdAddParam("@startDate", iso8601);
                DbConnParam.DbConn.Instance.CmdAddParam("@endDate", iso8601);
                DbConnParam.DbConn.Instance.CmdAddParam("@LSID", LSID);
                cb_AG.Items.Clear();
                DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
                int i = 0;
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
            /*------ Refill stopped ------*/
            catch (InvalidDateException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void bt_completed_change(bool completed)
        {
            if (completed == true)
            {
                bt_completed.BackColor = System.Drawing.Color.Green;
                bt_completed.ForeColor = System.Drawing.Color.Black;
                bt_completed.Text = "Completed";
            }
            else
            {
                bt_completed.BackColor = System.Drawing.Color.Red;
                bt_completed.ForeColor = System.Drawing.Color.White;
                bt_completed.Text = "Project Uncompleted";
            }

        }

        private string dateToIso8601(string Datestring)
        {
            DateTime date;
            string formattedDate;
            if (DateTime.TryParse(Datestring, out date))//Convert Date to ISO8601: 12.03.2024 --> 2024-03-12T00:00:00
            {
                // Konvertiere das Datum in das "s"-Format /sortierbare Form/
                formattedDate = date.ToString("s");
            } //Fill Datum
            else
            {
                formattedDate = "1000-00-00T00:00:00";
                throw new InvalidDateException("Ungültiges Datumsformat: dd.mm.yyyy");
            }
            return formattedDate;//Unfinished, not yet in use
        }
        private string iso8601ToDate(string dateIso8601)
        {
            string datestring;
            DateTime date;
            if (DateTime.TryParseExact(dateIso8601, "s", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                // Konvertiere das Datum in das ShortDateString-Format
                datestring = date.ToShortDateString();

            }
            else
            {
                datestring = "";
                throw new InvalidDateException("DateNotInIso8601: iso8601ToDate() needs '2023-04-11T00:00:00'");
            }
            return datestring;
        }


        [Serializable]
        public class InvalidDateException : Exception
        {
            public InvalidDateException() : base() { }
            public InvalidDateException(string message) : base(message) { }
            public InvalidDateException(string message, Exception inner) : base(message, inner) { }
        }

        private void bt_completed_Click(object sender, EventArgs e)
        {
            completed = !completed;
            bt_completed_change(completed);
        }
    }
}
