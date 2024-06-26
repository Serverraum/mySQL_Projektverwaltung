﻿using System;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
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
                tb_database.Enabled = false;
                label3.Enabled = false;
                tb_uid.Enabled = false;
                label4.Enabled = false;
                tb_pwd.Enabled = false;
                label5.Enabled = false;
                bt_showPWD.Enabled = false;


            }
            else
            {
                tb_server.Enabled = true;
                label2.Enabled = true;
                tb_database.Enabled = true;
                label3.Enabled = true;
                tb_uid.Enabled = true;
                label4.Enabled = true;
                tb_pwd.Enabled = true;
                label5.Enabled = true;
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
            if (!(SQLiteConn is null) && SQLiteConn.Length > 22) { tb_DB_File.Text = SQLiteConn.Substring(12, (SQLiteConn.Length - 22)); } else { tb_DB_File.Text = ""; };

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
            DbConnParam.DbConn.Instance.connParamNewSQLite(tb_DB_File.Text);
            DbConnParam.DbConn.Instance.connParamNewMySQL(tb_server.Text, tb_database.Text, tb_uid.Text, tb_pwd.Text);
            //Set Database-Type
            if (rb_SQLite.Checked) { DbConnParam.DbConn.Instance.connParamNewDbType(1); } else if (rb_mySQL.Checked) { DbConnParam.DbConn.Instance.connParamNewDbType(2); }

        }
    }
}
