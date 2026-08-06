using mySQL_Projektverwaltung;
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
    public partial class LS_Control : System.Windows.Forms.UserControl
    {
        public LS_Control()
        {
            InitializeComponent();
        }
        bool newLS = false;
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

            string sql = "SELECT * FROM ls WHERE LSID=@lsid";//datecreated < @endDate AND (dateremoved > @startDate OR dateremoved IS NULL)";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@lsid", this.Tag.ToString());
            //DbConnParam.DbConn.Instance.CmdAddParam("@startDate", dtProj.Rows[0][1].ToString());
            //cb_LS.Items.Clear();
            int i = 0;
            DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
            dtp_datecreated.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
            DBNull dbNullValue = DBNull.Value;
            if (dt.Rows[0][3] == dbNullValue)
            {
                dtp_dateremoved.Value = DateTime.MinValue.AddYears(1752);
                dtp_dateremoved.Enabled = false;
                cb_removed_null.Checked = true;
            }
            else
            {
                dtp_dateremoved.Value = Convert.ToDateTime(dt.Rows[0][3]);
                dtp_dateremoved.Enabled = true;
                cb_removed_null.Checked = false;
            }

            tb_LS.Text = dt.Rows[0][1].ToString();







            ///Get all LS
            ///


            //sql = "SELECT * FROM ag WHERE dateremoved IS NULL AND LSID = @lsid ";
            sql = "SELECT * FROM ag WHERE LSID = @lsid ";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@lsid", this.Tag.ToString());
            tabControl1.TabPages.Clear();

            dt = DbConnParam.DbConn.Instance.DbGetDataTable();

            i = 0;
            TabPage tpo;
            foreach (DataRow dr in dt.Rows)
            {

                tpo = new TabPage(dr[2].ToString());
                tpo.Tag = dr[0].ToString();
                tabControl1.TabPages.Add(tpo);

                AG_Control ag1 = new AG_Control();
                ag1.Tag = dr[1].ToString(); //LSID
                ag1.Name = dr[0].ToString();//AGID
                ag1.Dock = DockStyle.Fill;
                tpo.Controls.Add(ag1);
                i++;
            }
            tpo = new TabPage("Neu");

            tpo.Name = "0";
            tpo.Tag = this.Tag.ToString();
            tabControl1.TabPages.Add(tpo);
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            //int c = ListRowCount[0];
            //i = ListRowCount.Count;

            //while (i > 0)
            //{
            //    i--;
            //    if (ListRowCount[i] > 0) { ag1.BackColor = Color.OliveDrab; } else { ag1.ForeColor = Color.Green; }
            //}
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

            newLS = true;

            dtp_datecreated.Value = DateTime.Now;
            //dtp_dateremoved.Value = DateTime.Now;
            dtp_dateremoved.Checked = false;
            //dtp_dateremoved.MinDate = DateTime.MinValue; 
            dtp_dateremoved.Value = DateTime.MinValue.AddYears(1752);
            dtp_dateremoved.Enabled = false;
            cb_removed_null.Checked = true;
            tb_LS.Text = "";



            TabPage tpo;
            tpo = new TabPage("Neu");
            tpo.Tag = "new";
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tpo);

            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting); //Funktioniert hier bei einem Tab nicht. Muss manuell laden
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != null)
            {
                if (e.TabPage.Name.ToString() == null || e.TabPage.Name.ToString() == "0")
                {
                    tabControl1.SelectedTab.Controls.Clear();
                    //e.TabPage.Controls.Clear();
                    AG_Control ag1 = new AG_Control();
                    ag1.Load -= ag1.AG_Control_Load;
                    ag1.Load += ag1.AG_Control_New;
                    ag1.Tag = e.TabPage.Tag.ToString(); //LSID: wird ausgelesen
                    ag1.Name = "0"; //Backup
                    ag1.Dock = DockStyle.Fill;
                    tabControl1.SelectedTab.Controls.Add(ag1);
                    //e.TabPage.Controls.Add(ls1);
                    //throw new NotImplementedException();
                }
                else
                {
                    tabControl1.SelectedTab.Controls.Clear();
                    string sql = "SELECT * FROM ag WHERE agid=@agid";
                    DbConnParam.DbConn.Instance.DbAddCmd(sql);
                    DbConnParam.DbConn.Instance.CmdAddParam("@agid", e.TabPage.Tag.ToString());
                    DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

                    AG_Control ag1 = new AG_Control();
                    ag1.Tag = dt.Rows[0][1].ToString(); //AGID
                    ag1.Name = dt.Rows[0][0].ToString(); //LSID
                    ag1.Dock = DockStyle.Fill;
                    tabControl1.SelectedTab.Controls.Add(ag1);
                }
            }
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
                dtp_dateremoved.Value = DateTime.Now;
            }
        }

        private void bt_saveLS_Click(object sender, EventArgs e)
        {
            if (newLS == true){
                string sql = @"INSERT INTO ls (LS, datecreated, dateremoved,) VALUES (@LS, @datecreated, @dateremoved)";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@ls", tb_LS.Text);
                string DateTimeString = DateTime.Now.ToString("s");
                DbConnParam.DbConn.Instance.CmdAddParam("@datecreated", DateTimeString);
                if (dtp_dateremoved.Value == DateTime.MinValue.AddYears(1752))
                {
                    DateTimeString = dtp_dateremoved.Value.ToString("s");
                    DBNull dbNullValue = DBNull.Value;
                    DbConnParam.DbConn.Instance.CmdAddParam("@dateremoved", dbNullValue);
                }
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
            }
            else {
                string sql = "UPDATE ls set LS=@ls, datecreated=@datecreated, dateremoved=@dateremoved WHERE LSID= @lsid";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@lsid", this.Tag.ToString());
                DbConnParam.DbConn.Instance.CmdAddParam("@ls", tb_LS.Text);
                string DateTimeString = dtp_datecreated.Value.ToString("s");
                DbConnParam.DbConn.Instance.CmdAddParam("@datecreated", DateTimeString);
                if (dtp_dateremoved.Value == DateTime.MinValue.AddYears(1752))
                {
                    DateTimeString = dtp_dateremoved.Value.ToString("s");
                    DBNull dbNullValue = DBNull.Value;
                    DbConnParam.DbConn.Instance.CmdAddParam("@dateremoved", dbNullValue);
                }
                else {
                    DateTimeString = dtp_dateremoved.Value.ToString("s");
                    DbConnParam.DbConn.Instance.CmdAddParam("@dateremoved", DateTimeString);
                }
                DbConnParam.DbConn.Instance.DbExecuteNonQuery();
            };
        }
    }
}
