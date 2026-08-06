using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung.Tab_LS_AG
{
    public partial class AG_Control : System.Windows.Forms.UserControl
    {
        public AG_Control()
        {
            InitializeComponent();
        }

        bool newAG = false;

        public void AG_Control_Load(object sender, EventArgs e)
        {

            // Prüfen, ob das Control oder das übergeordnete Fenster gerade zerstört wird
            if (this.Disposing || this.IsDisposed) return;

            Form parentForm = this.FindForm();
            if (parentForm == null || parentForm.Disposing || parentForm.IsDisposed)
            {
                // Wenn wir hier landen, versucht WinForms das Control nach dem Schließen neu zu laden!
                return;
            }

            string sql = "SELECT * FROM ag WHERE AGID=@agid";//datecreated < @endDate AND (dateremoved > @startDate OR dateremoved IS NULL)";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@agid", this.Name.ToString());
            //DbConnParam.DbConn.Instance.CmdAddParam("@startDate", dtProj.Rows[0][1].ToString());
            //cb_LS.Items.Clear();

            DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
            dtp_datecreated.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
            DBNull dbNullValue = DBNull.Value;
            if (dt.Rows[0][4] == dbNullValue)
            {
                dtp_dateremoved.Value = DateTime.MinValue.AddYears(1752);
                dtp_dateremoved.Enabled = false;
                cb_removed_null.Checked = true;
            }
            else
            {
                dtp_dateremoved.Value = Convert.ToDateTime(dt.Rows[0][4]);
                dtp_dateremoved.Enabled = true;
                cb_removed_null.Checked = false;
            }

            tb_AG.Text = dt.Rows[0][2].ToString();
            cb_extra_bill.Checked = Convert.ToBoolean(dt.Rows[0][6]);

        }

        public void AG_Control_New(object sender, EventArgs e)
        {

            // Prüfen, ob das Control oder das übergeordnete Fenster gerade zerstört wird
            if (this.Disposing || this.IsDisposed) return;

            Form parentForm = this.FindForm();
            if (parentForm == null || parentForm.Disposing || parentForm.IsDisposed)
            {
                // Wenn wir hier landen, versucht WinForms das Control nach dem Schließen neu zu laden!
                return;
            }

            newAG = true;

            dtp_datecreated.Value = DateTime.Now;
            //dtp_dateremoved.Value = DateTime.Now;
            dtp_dateremoved.Checked = false;
            //dtp_dateremoved.MinDate = DateTime.MinValue; 
            dtp_dateremoved.Value = DateTime.MinValue.AddYears(1752);
            dtp_dateremoved.Enabled = false;
            cb_removed_null.Checked = true;
            tb_AG.Text = "";
        }

        private void cb_removed_null_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_removed_null.Checked == true)
            {
                dtp_dateremoved.Enabled = false;
                dtp_dateremoved.Value = DateTime.MinValue.AddYears(1752);
            }
            else
            {
                dtp_dateremoved.Enabled = true;
                string sql = "SELECT dateremoved FROM ag WHERE AGID = @agid ";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@agid", this.Name.ToString());
                DateTime dt = new DateTime();
                if (DbConnParam.DbConn.Instance.DbScalar() == DBNull.Value)
                {
                    dtp_dateremoved.Value = DateTime.Now;
                }
                else
                {
                    dtp_dateremoved.Value = (DateTime)DbConnParam.DbConn.Instance.DbScalar();
                }

            }
        }

        private void bt_saveAG_Click(object sender, EventArgs e)
        {
            if (newAG == true)
            {
                string sql = @"INSERT INTO ag (LSID, AG, datecreated, dateremoved, extra_bill) VALUES (@lsid, @ag, @datecreated, @dateremoved, @extra_bill )";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@extra_bill", cb_extra_bill.Checked);
                DbConnParam.DbConn.Instance.CmdAddParam("@lsid", this.Tag.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@ag", tb_AG.Text);
                string DateTimeString = dtp_datecreated.Value.ToString("s");
                DbConnParam.DbConn.Instance.CmdAddParam("@datecreated", DateTimeString);
                if (dtp_dateremoved.Value == DateTime.MinValue.AddYears(1752))
                {
                    DateTimeString = dtp_dateremoved.Value.ToString("s");
                    DBNull dbNullValue = DBNull.Value;
                    DbConnParam.DbConn.Instance.CmdAddParam("@dateremoved", dbNullValue);
                }
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
            }
            else
            {
                string sql = "UPDATE ag set AG=@ag, LSID=@lsid, datecreated=@datecreated, dateremoved=@dateremoved, extra_bill=@extra_bill WHERE AGID= @agid";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@extra_bill", cb_extra_bill.Checked);
                DbConnParam.DbConn.Instance.CmdAddParam("@lsid", this.Tag.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@agid", this.Name.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@ag", tb_AG.Text);
                string DateTimeString = dtp_datecreated.Value.ToString("s");
                DbConnParam.DbConn.Instance.CmdAddParam("@datecreated", DateTimeString);
                if (dtp_dateremoved.Value == DateTime.MinValue.AddYears(1752))
                {
                    DateTimeString = dtp_dateremoved.Value.ToString("s");
                    DBNull dbNullValue = DBNull.Value;
                    DbConnParam.DbConn.Instance.CmdAddParam("@dateremoved", dbNullValue);
                }
                else
                {
                    DateTimeString = dtp_dateremoved.Value.ToString("s");
                    DbConnParam.DbConn.Instance.CmdAddParam("@dateremoved", DateTimeString);
                }
                DbConnParam.DbConn.Instance.DbExecuteNonQuery();
            };

            //Update the parent form to reflect changes
            //this.Parent.;
        }

    }
}
