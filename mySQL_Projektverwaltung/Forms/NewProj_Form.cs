using mySQL_Projektverwaltung.Tab_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using mySQL_Projektverwaltung;
using System.Windows.Media;
using static mySQL_Projektverwaltung.Main;

namespace mySQL_Projektverwaltung
{
    public partial class NewProj_Form : Form
    {
        string projDate = DateTime.Now.ToString("s");
        string projLSID = "0";
        string projAGID = "0";

        public NewProj_Form()
        {
            InitializeComponent();




            //cmd.CommandText = @"INSERT INTO projTime (date, description, time_h, ProjID, LSID, AGID) VALUES (@date, @description, @time_h, @projID, 1, 1)";
            try
            {

                /* -- Prepare UI -- */

                /*------ Set combobox_LS ------*/
                string sql = "SELECT * FROM ls WHERE datecreated < @endDate AND (dateremoved > @startDate OR dateremoved IS NULL)";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@endDate", projDate);
                DbConnParam.DbConn.Instance.CmdAddParam("@startDate", projDate);
                cb_LS.Items.Clear();
                int i = 0;
                DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
                foreach (DataRow dr in dt.Rows)
                {
                    cb_LS.Items.Add(dr[1].ToString());
                    if (i == 0)
                    {
                        cb_LS.SelectedIndex = i;
                        projLSID = dr[0].ToString();
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



        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }




















        DataTable dtProj = new DataTable();



        private void bt_proj_save_Click(object sender, EventArgs e) //Save Function
        {
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
                sql = @"INSERT proj (date, LSID, AGID, name, email, tel, desc_short) VALUE (@date, @LSID, @AGID, @name, @email, @tel, @desc_short)";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                //DbConnParam.DbConn.Instance.CmdAddParam("@id", projID);


                /*------ Add Params ------*/
                string iso8601 = DateTime.Now.ToString("s");
                DbConnParam.DbConn.Instance.CmdAddParam("@date", iso8601);
                DbConnParam.DbConn.Instance.CmdAddParam("@LSID", LSID); // cb_LS.SelectedItem.ToString()=> "Lanz"
                DbConnParam.DbConn.Instance.CmdAddParam("@AGID", AGID);
                DbConnParam.DbConn.Instance.CmdAddParam("@name", tb_name.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@email", tb_email.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@tel", tb_tel.Text.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@desc_short", tb_shortdesc.Text.ToString());
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();

                if (i == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    /*------ Reload Main Project Page ------*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cb_LS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*Get LSID from Database*/
            /*'LS Parodi' --> LSID=3 */
            string sql = @"SELECT LSID FROM ls WHERE LS=@LS";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@LS", cb_LS.SelectedItem.ToString());
            string LSID = DbConnParam.DbConn.Instance.DbScalar().ToString(); ; //get LSID from name, da cb_LS keine Tags unterstützt


            string dateString = DateTime.Now.ToString("s");
            cb_AG_Refill(dateString, LSID);
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
                    if (i == 0)
                    {
                        cb_AG.SelectedIndex = i;
                        projAGID = dr[0].ToString();
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

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        /*--- --- --- Exceptions --- --- ---*/
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        [Serializable]
        public class InvalidDateException : Exception
        {
            public InvalidDateException() : base() { }
            public InvalidDateException(string message) : base(message) { }
            public InvalidDateException(string message, Exception inner) : base(message, inner) { }
        }

        //project_PrintControl1.CreateDocumentProj += Project_PrintControl1_CreateDocumentProj;



    }

}



