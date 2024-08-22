using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbConn = mySQL_Projektverwaltung.DbConnParam.DbConn;


namespace mySQL_Projektverwaltung
{
    public partial class ProjAuswahl : Form
    {
        public event EventHandler<TreeNodeClickedEventArgs> TreeNodeClicked;

        DataTable dt = new DataTable();


        public ProjAuswahl()
        {
            InitializeComponent();
        }

        public void UpdateSurface()
        {
            treeView1.Nodes.Clear();
            ProjAuswahl_Load(this, new EventArgs());
        }

        protected virtual void OnTreeNodeClicked(TreeNodeClickedEventArgs e)
        {
            TreeNodeClicked?.Invoke(this, e);
        }
        // Methode zum Verarbeiten des Klicks auf den Knoten im TreeView
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Löse das Ereignis aus und sende den angeklickten Knoten zurück
            OnTreeNodeClicked(new TreeNodeClickedEventArgs(e.Node));
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ProjAuswahl_Load(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT * FROM proj"; //WHERE projID=" + projID;
                DbConn.Instance.DbAddCmd(sql);
                dt = DbConn.Instance.DbGetDataTable();
                PopulateTreeView(treeView1 as TreeView, dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateTreeView(TreeView treeView, DataTable dataTable)
        {
            // Datensätze nach Jahr sortieren
            DataView dataView = dataTable.DefaultView;
            dataView.Sort = "date DESC";

            foreach (DataRowView rowView in dataView)
            {
                DataRow row = rowView.Row;
                DateTime date = Convert.ToDateTime(row["date"]);
                int year = date.Year;

                TreeNode yearNode = FindOrCreateNode(treeView.Nodes, year.ToString(), year.ToString(), null);

                int projId = Convert.ToInt32(row["ProjID"]);
                string projectName = row["desc_short"].ToString();
                bool finished = Convert.ToBoolean(row["completed"]);

                TreeNode projectNode = new TreeNode(projectName);
                projectNode.Tag = projId;
                projectNode.ForeColor = finished ? Color.Green : Color.Red;

                yearNode.Nodes.Add(projectNode);
            }
            treeView1.Nodes[0].Expand();
        }

        private TreeNode FindOrCreateNode(TreeNodeCollection nodes, string key, string text, object tag)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Name == key)
                    return node;
            }

            TreeNode newNode = new TreeNode(text);
            newNode.Name = key;
            newNode.Tag = tag;
            nodes.Add(newNode);
            return newNode;
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Right)
            {
                // Prüfe, ob ein Knoten ausgewählt ist
                if (treeView1.SelectedNode != null)
                {
                    // Erzeuge das gleiche Ereignis wie bei einem Mausklick
                    OnTreeNodeClicked(new TreeNodeClickedEventArgs(treeView1.SelectedNode));
                }
                 treeView1.Focus();
            }
        }
    }
}


    public class TreeNodeClickedEventArgs : EventArgs
    {
        public TreeNode ClickedNode { get; }

        public TreeNodeClickedEventArgs(TreeNode clickedNode)
        {
            ClickedNode = clickedNode;
        }
    }

