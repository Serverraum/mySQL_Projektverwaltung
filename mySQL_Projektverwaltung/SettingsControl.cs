using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mySQL_Projektverwaltung.Main;

namespace mySQL_Projektverwaltung
{
    public partial class SettingsControl : UserControl
    {
        //DbConn dbConn = new DbConn();

        public SettingsControl()
        {
            InitializeComponent();
        }

        /*##########################---------------------##############################*/
        /*########################## Start of UI-Control ##############################*/
        /*##########################---------------------##############################*/
        //only graphical Stuff is made here

        private void tb_DB_File_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_DB_File.Text = DbConnParam.DbConn.Instance.connParamGetSQLite();
        }

        private void tb_server_TextChanged(object sender, EventArgs e)
        {
            if (tb_server.Text.Length > 0) { hint_server.Visible = false; } else { hint_server.Visible = true; };
        }

        private void tb_database_TextChanged(object sender, EventArgs e)
        {
            if (tb_database.Text.Length > 0) { hint_database.Visible = false; } else { hint_database.Visible = true; };
        }

        private void tb_uid_TextChanged(object sender, EventArgs e)
        {
            if (tb_uid.Text.Length > 0) { hint_UID.Visible = false; } else { hint_UID.Visible = true; };
        }

        private void tb_pwd_TextChanged(object sender, EventArgs e)
        {
            if (tb_pwd.Text.Length > 0) { hint_pwd.Visible = false; } else { hint_pwd.Visible = true; };
        }

        private void rb_SQLite_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_SQLite.Checked)
            {
                Button_SetDB.Enabled = false;
                label8.Enabled = false;
            }
            else
            {
                Button_SetDB.Enabled = true;
                label8.Enabled = true;
            };
        }

        private void rb_mySQL_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_mySQL.Checked)
            {
                tb_server.Enabled = false;
                label2.Enabled = false;
                hint_server.BackColor = System.Drawing.SystemColors.Control;
                tb_database.Enabled = false;
                label3.Enabled = false;
                hint_database.BackColor = System.Drawing.SystemColors.Control;
                tb_uid.Enabled = false;
                label4.Enabled = false;
                hint_UID.BackColor = System.Drawing.SystemColors.Control;
                tb_pwd.Enabled = false;
                label5.Enabled = false;
                hint_pwd.BackColor = System.Drawing.SystemColors.Control;
                bt_showPWD.Enabled = false;


            }
            else
            {
                tb_server.Enabled = true;
                label2.Enabled = true;
                hint_server.BackColor = System.Drawing.SystemColors.Window;
                tb_database.Enabled = true;
                label3.Enabled = true;
                hint_database.BackColor = System.Drawing.SystemColors.Window;
                tb_uid.Enabled = true;
                label4.Enabled = true;
                hint_UID.BackColor = System.Drawing.SystemColors.Window;
                tb_pwd.Enabled = true;
                label5.Enabled = true;
                hint_pwd.BackColor = System.Drawing.SystemColors.Window;
                bt_showPWD.Enabled = true;

            };
        }

        private void bt_showPWD_Click(object sender, EventArgs e)
        {
            if (!tb_pwd.UseSystemPasswordChar)
            {
                tb_pwd.UseSystemPasswordChar = true;
            }
            else { tb_pwd.UseSystemPasswordChar = false; }
        }
        /*###########################-------------------###############################*/
        /*########################### End of UI-Control ###############################*/
        /*###########################-------------------###############################*/
        private void Button_SetDB_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse SQLite Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "db",
                Filter = "SQLite files (*.sqlite;*.db;*.sqlite3;*.db3)|*.sqlite;*.db;*.sqlite3;*.db3|All Files|*",
                FilterIndex = 4,
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_DB_File.Text = openFileDialog1.FileName;

                  DbConnParam.DbConn.Instance.connParamNewSQLite(openFileDialog1.FileName);
                /*config = new DatabaseConfig
                {
                    // Beispiel-Pfad zur SQLite-Datenbank
                    DatabasePath = @"Data Source=" + openFileDialog1.FileName + @";version=3" //"C:\\path\\to\\your-database.db"
                };

                // Serialisiere und speichere die Standardkonfiguration
                string defaultConfigJson = JsonSerializer.Serialize(config);
                File.WriteAllText(Main.configFilePath, defaultConfigJson);*/
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            //Load SQLite-String
            string SQLiteConn = DbConnParam.DbConn.Instance.connParamGetSQLite();
            if ( !(SQLiteConn is null) && SQLiteConn.Length> 22) { tb_DB_File.Text = SQLiteConn.Substring(12, (SQLiteConn.Length-22)); } else { tb_DB_File.Text = ""; };

            //Load MySQL-String + DbType; Also check, if data is not null

            DbConnParam.MySQLParam mySQLParam = DbConnParam.DbConn.Instance.connParamGetMySQL();
            if (!(mySQLParam.mySQL_Addr is null)) { tb_server.Text = mySQLParam.mySQL_Addr; };
            if (!(mySQLParam.mySQL_Dat is null)) { tb_database.Text = mySQLParam.mySQL_Dat; };
            if (!(mySQLParam.mySQL_UID is null)) { tb_uid.Text = mySQLParam.mySQL_UID; };
            if (!(mySQLParam.mySQL_PWD is null)) { tb_pwd.Text = mySQLParam.mySQL_PWD; };
            switch (mySQLParam.DbType) // Check active Database-Field
            {
                case 1: rb_SQLite.Checked = true; break;
                case 2: rb_mySQL.Checked = true; break;
                default: break;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            //Set Database-Type
            if (rb_SQLite.Checked) { DbConnParam.DbConn.Instance.connParamNewDbType(1); } else if (rb_mySQL.Checked) { DbConnParam.DbConn.Instance.connParamNewDbType(2); }

            DbConnParam.DbConn.Instance.connParamNewSQLite(tb_DB_File.Text);
            DbConnParam.DbConn.Instance.connParamNewMySQL(tb_server.Text, tb_database.Text, tb_uid.Text, tb_pwd.Text);
        }
    }
}
