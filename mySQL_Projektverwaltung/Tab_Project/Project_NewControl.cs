using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung.Tab_Project
{
    public partial class Project_NewControl : UserControl
    {
        public Project_NewControl()
        {
            InitializeComponent();
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            var form = new NewProj_Form();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //LoadNewProject
            }
            /*using (var form = new NewProj_Form())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    
                    MessageBox.Show("Project Created");
                    ///Create Folder

                }

            }
            */
        }
    }
}
