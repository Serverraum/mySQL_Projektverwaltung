using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Media.Media3D;
using System.Globalization;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using mySQL_Projektverwaltung.Tab_Project;
using System.Configuration;
using QuestPDF.Infrastructure;

namespace mySQL_Projektverwaltung
{


    public partial class Main : Form
    {
        ReadTest robertzeigtmirwas = new ReadTest();


        public String connectString;
        int projID = 0;
        int i;
        public Boolean ProjLoad;
        private ProjAuswahl projAuswahl;

        public Main()
        {
            //string sAttr = Properties.Settings.Default.test;
            //splitContainer_horiz_left.SplitterDistance
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            InitializeComponent();
            DbConnParam.DbConn.Instance.connLoadParam();
            splitContainer_horiz_right.SplitterDistance = Settings.Instance.MainSlider.Slider1;
            splitContainer_mid_horiz.SplitterDistance = Settings.Instance.MainSlider.Slider2;
            splitContainer_right_vert.SplitterDistance = Settings.Instance.MainSlider.Slider3;


            
        }
        public void LoadProject(int projID)
        {
            project_TimeControl1.ReLoad_Project_TimeControl(projID);
            project_MainControl1.ReLoad_Project_MainControl(projID);
            if (!pictureList1.Enabled) { pictureList1.Enabled = !pictureList1.Enabled; };
            pictureList1.ReLoad_Project_PictureList(projID);
            if (!project_DetailsControl1.Enabled) { project_DetailsControl1.Enabled = !project_DetailsControl1.Enabled; };
            project_DetailsControl1.ReLoad_Project_DetailsControl(projID);
            project_FolderControl1.ReLoad_Project_FolderControl(projID);

        }



        private void ProjAuswahl_TreeNodeClicked(object sender, TreeNodeClickedEventArgs e)
        {
            TreeNode clickedNode = e.ClickedNode;
            // Hier kannst du den geklickten Knoten verwenden, z. B.:
            //MessageBox.Show($"Knoten '{clickedNode.Text}' wurde in Form1 geklickt.'{clickedNode.Tag}' ");
            if (clickedNode.Tag != null)
            {
                this.BringToFront();
                ProjLoad = true;
                //MessageBox.Show(clickedNode.Tag.ToString());
                projID = Convert.ToInt32(clickedNode.Tag);
                LoadProject(projID);




                ProjLoad = false;

               
            }
        }


        public void Main_Load(object sender, EventArgs e)
        {
            if (projID > 0)
            {
                LoadProject(projID);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            projAuswahl = new ProjAuswahl();
            projAuswahl.TreeNodeClicked += ProjAuswahl_TreeNodeClicked;
            projAuswahl.Show();

        }





       
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Instance.MainSlider.Slider1 = splitContainer_horiz_right.SplitterDistance;
            Settings.Instance.MainSlider.Slider2 = splitContainer_mid_horiz.SplitterDistance;
            Settings.Instance.MainSlider.Slider3 = splitContainer_right_vert.SplitterDistance;
            DbConnParam.DbConn.Instance.connSaveParam();
            DbConnParam.DbConn.Instance.connClose();
        }
    }

    public class MainSlider
    {
        [JsonInclude]
        public int Slider1 = 200;
        [JsonInclude]
        public int Slider2 = 200;
        [JsonInclude]
        public int Slider3 = 200;
    }
    public sealed partial class Settings
    {
        public MainSlider MainSlider { get; set; } = new MainSlider();
    }
}
