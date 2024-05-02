﻿using System;
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


namespace mySQL_Projektverwaltung
{


    public partial class Main : Form
    {
        ReadTest robertzeigtmirwas = new ReadTest();
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataSet ds = new DataSet();
        DataSet dsProj = new DataSet();
        DataSet dsLS = new DataSet();
        DataSet dsAG = new DataSet();
        DataTable dt = new DataTable();
        DataTable dtProj = new DataTable();
        DataTable dtLS = new DataTable();
        DataTable dtAG = new DataTable();
        bool isDoubleClick = false;
        public String connectString;
        int projID = 0;
        int i;
        public Boolean ProjLoad;
        private ProjAuswahl projAuswahl;
        private string filePath = @"C:/";
        private bool isFile = false;
        private string currentlySelectedItemName = "";

        public Main()
        {
            InitializeComponent();
            DbConnParam.DbConn.Instance.connLoadParam();

            //can be removed
            connectString = @"Data Source=C:\Users\faesc\Desktop\Projekmanagement_App\projekt.db;version=3";
        }
        public void LoadProject(int projID)
        {
            project_TimeControl1.ReLoad_Project_TimeControl(projID);
            project_MainControl1.ReLoad_Project_MainControl(projID);
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

                tb_DB_File.Text = DbConnParam.DbConn.Instance.connParamGetSQLite();
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




       
        public int iger = 1;
        private void Button_SetDB_Click(object sender, EventArgs e)
        {
            try
            {
                //label8.Text = this.currentlySelectedItemName;
                DbConnParam.DbConn.Instance.DbAddCmd("Select LS FROM ls WHERE lsid=@lsid");
                DbConnParam.DbConn.Instance.CmdAddParam("lsid", iger);
                label8.Text = DbConnParam.DbConn.Instance.DbScalar().ToString();
                iger++;
            }
            catch (Exception)
            {
                //MessageBox.Show(Exception);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DbConnParam.DbConn.Instance.connClose();
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
