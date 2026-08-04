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

        private void bt_saveAG_Click(object sender, EventArgs e)
        {

        }

        bool newAG = false;
        
        public void LS_Control_Load(object sender, EventArgs e)
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
            DbConnParam.DbConn.Instance.CmdAddParam("@agid", this.Tag.ToString());
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

        public void LS_Control_New(object sender, EventArgs e)
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
    }
}
