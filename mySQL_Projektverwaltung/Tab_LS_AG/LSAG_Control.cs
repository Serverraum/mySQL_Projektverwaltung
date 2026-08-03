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
            List<int> ListRowCount = new List<int>();

            /*TabPage tp = new TabPage("Test");
            tabControl1.TabPages.Add(tp);

            TextBox tb = new TextBox();
            tb.Dock = DockStyle.Fill;
            tb.Multiline = true;

            tp.Controls.Add(tb);*/

            ///Get all LS
            ///
           

            string sql = "SELECT * FROM ls WHERE dateremoved IS NULL";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            tabControl1.TabPages.Clear();

            DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

            int i = 0;
            TabPage tpo;
            foreach (DataRow dr in dt.Rows)
            {

                tpo = new TabPage(dr[1].ToString());
                tpo.Tag = dr[1].ToString();
                tabControl1.TabPages.Add(tpo);

                LS_Control ls1 = new LS_Control();
                ls1.Tag = 2026;
                ls1.Name = dr[0].ToString();
                ls1.Dock = DockStyle.Fill;
                tpo.Controls.Add(ls1);
                //ag1.Uebersicht_AG_Count();
                //ListRowCount.Add(ls1.rowCount);
                //if (ListRowCount[i] == 0) { tabControl1.TabPages.Remove(tpo); } else { ls1.ForeColor = Color.Green; }
                i++;
            }
            tpo = new TabPage("Neu");
            tpo.Tag = "new";
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

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Tag.ToString() == "new") {
                throw new NotImplementedException();
            }
        }
    }
}
