using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung.Tab_Übersicht
{
    public partial class Uebersicht_MainControl : UserControl
    {
        bool old = false;
        public Uebersicht_MainControl()
        {
            InitializeComponent();

            //On First Opening - set year_select_UD maximum + value to current year
            if (old == false)
            {
                old = !old;
                DateTime date = DateTime.Now;

                year_select_UD.Maximum = date.Year;
                year_select_UD.Value = date.Year;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = year_select_UD.Value.ToString();
            int year = (int)year_select_UD.Value;
            /*TabPage tp = new TabPage("Test");
            tabControl1.TabPages.Add(tp);

            TextBox tb = new TextBox();
            tb.Dock = DockStyle.Fill;
            tb.Multiline = true;

            tp.Controls.Add(tb);*/

            ///Get all LS for selected year 
            ///
            DateTime date = DateTime.Now;

            string sql = "SELECT * FROM ls WHERE datecreated < @endDate AND (dateremoved > @startDate OR dateremoved IS NULL)";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@endDate", date.ToString("s")/* Konvertiere das Datum in das "s"-Format /sortierbare Form/ */);
            DbConnParam.DbConn.Instance.CmdAddParam("@startDate", date.ToString("s"));
            tabControl1.TabPages.Clear();

            DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

            TabPage tp = new TabPage("Test");
            foreach (DataRow dr in dt.Rows)
            {
                TabPage tpo = new TabPage(dr[1].ToString());
                tabControl1.TabPages.Add(tpo);

                Uebersicht_AG ag1 = new Uebersicht_AG();
                ag1.Name = dr[0].ToString();
                ag1.Dock = DockStyle.Fill;
                tpo.Controls.Add(ag1);
            }


            //TabPage tp = new TabPage("Test");
            tabControl1.TabPages.Add(tp);

            TextBox tb = new TextBox();
            tb.Dock = DockStyle.Fill;
            tb.Multiline = true;

            tp.Controls.Add(tb);
        }
    }
}
