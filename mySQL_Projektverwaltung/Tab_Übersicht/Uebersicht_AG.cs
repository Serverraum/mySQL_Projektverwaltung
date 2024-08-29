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

namespace mySQL_Projektverwaltung.Tab_Übersicht
{
    public partial class Uebersicht_AG : UserControl
    {
        public Uebersicht_AG()
        {
            InitializeComponent();
            //LS_name.Text = this.Name;
        }

        private void Uebersicht_AG_Load(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime || this.Tag is null)
            {
                LS_name.Text = "TestModus";
            }
            else {
                LS_name.Text = this.Tag.ToString();
                
                //dataGridView1.

                try
                {
                    dataGridView1.DataSource = null;
                    int year = (int)this.Tag;
                    int nextYear = year + 1;
                    string tyear = year.ToString() + "-00-00T00:00:00";
                    string tnextyear = nextYear.ToString() + "-00-00T00:00:00";


                    string sql = @"     SELECT
                                            ls.LS, ag.AG, SUM(time_h) as GesamtStunden
                                        FROM
                                            projTime pt, ls, ag
                                        WHERE pt.LSID = @LSID AND pt.`date` < @endDate AND pt.`date` > @startDate AND ls.LSID = pt.LSID AND ag.AGID = pt.AGID
	                                    GROUP BY pt.LSID, pt.AGID";
                    DbConnParam.DbConn.Instance.DbAddCmd(sql);
                    DbConnParam.DbConn.Instance.CmdAddParam("@LSID", this.Name);
                    DbConnParam.DbConn.Instance.CmdAddParam("@endDate", tnextyear);
                    DbConnParam.DbConn.Instance.CmdAddParam("@startDate", tyear);
                    DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

                    


                    dataGridView1.DataSource = dt;
                    //dataGridView1.Columns[0].HeaderText = "Datum";
                    //dataGridView1.Columns[1].HeaderText = "Beschreibung";
                    //dataGridView1.Columns[2].HeaderText = "Zeit";
                    //dataGridView1.Columns[0].Visible = false; //ID von projTime
                    //dataGridView1.Columns[4].Visible = false; //projID
                    //dataGridView1.Columns[5].Visible = false; //LSID
                    //dataGridView1.Columns[6].Visible = false; //AGID
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
