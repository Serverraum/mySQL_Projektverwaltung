using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung
{
    public partial class ProjFolder_Missing : Form
    {
        public ProjFolder_Missing()
        {
            InitializeComponent();
        }
        public RETURN ReturnValue { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = RETURN.Create;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ReturnValue = RETURN.Change;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ReturnValue = RETURN.Reset;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    public enum RETURN
    {
        Create = 1,
        Change = 2,
        Reset = 3
    }
}
