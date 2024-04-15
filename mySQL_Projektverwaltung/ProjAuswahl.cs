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
using static mySQL_Projektverwaltung.Main;


namespace mySQL_Projektverwaltung
{
    public partial class ProjAuswahl : Form
    {
        public event EventHandler<TreeNodeClickedEventArgs> TreeNodeClicked;

        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int id;
        bool isDoubleClick = false;
        String connectString;
        string configFilePath = "config.json";
        int projID = 0;

        DatabaseConfig config;
        private ProjAuswahl projAuswahl;

        public ProjAuswahl()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText(configFilePath);
                config = JsonSerializer.Deserialize<DatabaseConfig>(json);
            }
            catch (FileNotFoundException)
            {
                // Falls die Datei nicht gefunden wird, zeige Fehler (sollte in Hauptform erstellt werden.)
                MessageBox.Show("config.json nicht gefunden!");
            }
            connectString = config.DatabasePath;





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
                conn = new SQLiteConnection(connectString);
                conn.Open();
                cmd = new SQLiteCommand();
                //String sql = "SET IDENTITY_INSERT proj OFF;";
                //adapter = new SQLiteDataAdapter(sql, conn);
                String sql = "SELECT * FROM proj"; //WHERE projID=" + projID;
                adapter = new SQLiteDataAdapter(sql, conn);
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                PopulateTreeView(treeView1 as TreeView, dt);
                conn.Close();
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
                bool finished = Convert.ToBoolean(row["Finished"]);

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

