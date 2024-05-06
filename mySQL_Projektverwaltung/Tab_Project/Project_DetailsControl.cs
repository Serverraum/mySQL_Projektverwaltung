using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
//  Hard Connection to/from:                 //
//   - ProjMain  (project_MainControl1)      //
//   (For Save-Function)                     //
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
namespace mySQL_Projektverwaltung.Tab_Project
{
    public partial class Project_DetailsControl : UserControl
    {
        public Project_DetailsControl()
        {
            InitializeComponent();
        }
        public void ReLoad_Project_DetailsControl(int projID)
        {
            string sql = "SELECT desc_long FROM proj WHERE projID=@projID";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
            string text = "";
            try
            {
                text = DbConnParam.DbConn.Instance.DbScalar().ToString();
                richTextBox1.Rtf = text;
            }
            catch (ArgumentException) //Falls Text nicht im RTF-Format ist, Fallback auf Normaltext.
            {
                richTextBox1.Text = text;
            }
        }
        public string Save_Project_DetailsControl() { return richTextBox1.Rtf; }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*------ Change SaveState ------*/
            foreach (var item in Application.OpenForms)
            {
                Main main = item as Main;
                if (main != null)
                {
                    main.project_MainControl1.SaveStateChanged();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
