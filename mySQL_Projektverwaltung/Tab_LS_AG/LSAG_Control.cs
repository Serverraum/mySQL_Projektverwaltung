using Microsoft.VisualBasic;
using mySQL_Projektverwaltung.Tab_Übersicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace mySQL_Projektverwaltung.Tab_LS_AG
{
    public partial class LSAG_Control : UserControl
    {
        public LSAG_Control()
        {
            InitializeComponent();
        }

        private void LSAG_Control_Load(object sender, EventArgs e)
        {
            // Prüfen, ob das Control oder das übergeordnete Fenster gerade zerstört wird
            if (this.Disposing || this.IsDisposed) return;

            Form parentForm = this.FindForm();
            if (parentForm == null || parentForm.Disposing || parentForm.IsDisposed)
            {
                // Wenn wir hier landen, versucht WinForms das Control nach dem Schließen neu zu laden!
                return;
            }

            Load_LS();
        }
        long LSID = 0;
        private void Load_LS() {

            ///Get all LS
            ///

            //string sql = "SELECT * FROM ls WHERE dateremoved IS NULL";
            string sql = "SELECT * FROM ls";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            tabControl1.TabPages.Clear();

            DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

            int i = 0;
            TabPage tpo;
            foreach (DataRow dr in dt.Rows)
            {

                tpo = new TabPage(dr[1].ToString());
                tpo.Tag = dr[0];
                tabControl1.TabPages.Add(tpo);

                LS_Control ls1 = new LS_Control();
                ls1.Tag = dr[0].ToString(); //LSID: wird ausgelesen
                ls1.Name = dr[0].ToString(); //Backup
                ls1.Dock = DockStyle.Fill;
                tpo.Controls.Add(ls1);
                i++;
            }
            tpo = new TabPage("Neu");
            tpo.Tag = "0";
            tabControl1.TabPages.Add(tpo);
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPage != null){
                if ( e.TabPage.Tag.ToString() == null || e.TabPage.Tag.ToString() == "0")
                {
                    tabControl1.SelectedTab.Controls.Clear();
                    //e.TabPage.Controls.Clear();
                    LS_Control ls1 = new LS_Control();
                    ls1.Load -= ls1.LS_Control_Load;
                    ls1.Load += ls1.LS_Control_New;
                    ls1.Tag = "1"; //LSID: wird ausgelesen
                    ls1.Name = "1"; //Backup
                    ls1.Dock = DockStyle.Fill;
                    tabControl1.SelectedTab.Controls.Add(ls1);
                    //e.TabPage.Controls.Add(ls1);
                    //throw new NotImplementedException();
                }
                else {
                    tabControl1.SelectedTab.Controls.Clear();
                    string sql = "SELECT * FROM ls WHERE lsid=@lsid";
                    DbConnParam.DbConn.Instance.DbAddCmd(sql);
                    DbConnParam.DbConn.Instance.CmdAddParam("@lsid", e.TabPage.Tag.ToString());
                    DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
  
                    LS_Control ls1 = new LS_Control();
                    ls1.Tag = dt.Rows[0][0].ToString(); //LSID: wird ausgelesen
                    ls1.Name = dt.Rows[0][1].ToString(); //Backup
                    ls1.Dock = DockStyle.Fill;
                    tabControl1.SelectedTab.Controls.Add(ls1);
                }
            }
        }
    }
}
