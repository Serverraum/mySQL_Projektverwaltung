using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using static mySQL_Projektverwaltung.Main;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Text.Json.Serialization;
using System.Windows.Media.Media3D;
using System.Globalization;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Core.Mapping;
using Org.BouncyCastle.Asn1.Mozilla;

namespace mySQL_Projektverwaltung
{
    public class DbConnParam
    {
        [JsonInclude]
        protected String SQLiteAddr;
        [JsonInclude]
        protected int DbType; //1 =  SQLite; 2 = mySQL
        [JsonInclude]
        protected String mySQL_Addr;//Address to Database
        [JsonInclude]
        protected String mySQL_Dat; //Database
        [JsonInclude]
        protected String mySQL_PWD; //Password
        [JsonInclude]
        protected String mySQL_UID; //Username
        protected string configFilePath = "configdatabase.json";

        public class MySQLParam
        {
            internal String mySQL_Addr;
            internal String mySQL_Dat;
            internal String mySQL_PWD;
            internal String mySQL_UID;
            internal int DbType;
        }

        public sealed class DbConn //Init als Singleton-Funktion
        {
            private static readonly Lazy<DbConn> lazy =
                new Lazy<DbConn>(() => new DbConn());

            public static DbConn Instance { get { return lazy.Value; } }

            private DbConn()
            {
            }
            private string conn ="";
            DbConnParam dbConnParam = new DbConnParam();
            MySql.Data.MySqlClient.MySqlConnection connMySQL = new MySql.Data.MySqlClient.MySqlConnection();
            SQLiteConnection connSQLite = new SQLiteConnection();

            /*###########################--------------------##############################*/
            /*########################### Start of Functions ##############################*/
            /*###########################--------------------##############################*/
            //For use by all other functions


            /*******************************************************************************/
            /*                           JSON SAVE/LOAD-Functions                          */
            /*******************************************************************************/

            public void connLoadParam()// Load Param from JSON
            { 

                try
                {
                    //DbConnParam dbConnParam = new DbConnParam();
                    string json = File.ReadAllText(path: dbConnParam.configFilePath);
                    dbConnParam = JsonSerializer.Deserialize<DbConnParam>(json);
                    //.mySQL_Addr = @"Data Source=" + "T" + @";version=3";
                }
                catch (FileNotFoundException)
                {
                    // Falls die Datei nicht gefunden wird, erstelle eine neue Konfiguration
                    DbConnParam dbConnParam = new DbConnParam
                    {
                        // Beispiel-Pfad zur SQLite-Datenbank
                        SQLiteAddr = "",//"C:\\path\\to\\your-database.db"
                        DbType = 0,
                        mySQL_Addr = "",
                        mySQL_Dat = "",
                        mySQL_PWD = ""
                    };
            

                    // Serialisiere und speichere die Standardkonfiguration
                    string defaultConfigJson = JsonSerializer.Serialize(dbConnParam);
                    File.WriteAllText(dbConnParam.configFilePath, defaultConfigJson);
                    MessageBox.Show("DB not configured","Warning");
                    // ToDo: config DB
                }
            }
            public void connSaveParam()// Save Param to JSON
            { 
                string defaultConfigJson = JsonSerializer.Serialize(dbConnParam);
                File.WriteAllText(dbConnParam.configFilePath, defaultConfigJson);
            }


            public void connParamNewDbType(int DbType)// Set DbType 1:SQLite or 2:mySQL
            {
                dbConnParam.DbType = DbType;
            }
            public void connParamNewSQLite(string connectionString) // Save new SQLiteParams to JSON
            {

                String connectString = @"Data Source=" + connectionString + @";version=3";
                dbConnParam.SQLiteAddr = connectString;
                connSaveParam();
            }
            public void connParamNewMySQL(string addr, string database, string uid, string password)//Save new mySQLParams to JSON
            {
                dbConnParam.mySQL_Addr = addr;
                dbConnParam.mySQL_Dat = database;
                dbConnParam.mySQL_UID = uid;
                dbConnParam.mySQL_PWD = password;
                connSaveParam();
            }

            /*******************************************************************************/
            /*                UI-Interface-Functions for SettingsControl.cs                */
            /*******************************************************************************/

            public string connParamGetSQLite()//returns Data to fill the UserInterface for SQLite
            {
                return dbConnParam.SQLiteAddr;
            }
            public MySQLParam connParamGetMySQL()//returns Data to fill the UserInterface for mySQL
            {
                MySQLParam mySQLParam = new MySQLParam();
                mySQLParam.mySQL_Addr = dbConnParam.mySQL_Addr;
                mySQLParam.mySQL_UID = dbConnParam.mySQL_UID;
                mySQLParam.mySQL_PWD = dbConnParam.mySQL_PWD;
                mySQLParam.mySQL_Dat = dbConnParam.mySQL_Dat;
                mySQLParam.DbType = dbConnParam.DbType;
                return mySQLParam;
            }

            /*******************************************************************************/
            /*                         Database-Interface-Functions                        */
            /*******************************************************************************/

            /*-----------------------------------Prepare-----------------------------------*/

            public void DbGetValue(string cmd) { 
            switch(dbConnParam.DbType)
                {
                    case 1: dbConnParam.DbType = 1;
                        SQLiteConnection connSQLite = new SQLiteConnection(dbConnParam.SQLiteAddr);
                        connSQLite.Open(); //open Connection
                        SQLiteCommand cmdSQLite = connSQLite.CreateCommand(); //create Command
                        cmdSQLite.CommandText = cmd; //Applying commandtext to Command
                        break;
                    case 2: dbConnParam.DbType = 2; //same as above
                        MySql.Data.MySqlClient.MySqlConnection connMySQL = new MySql.Data.MySqlClient.MySqlConnection(dbConnParam.mySQL_Addr + ";"+dbConnParam.mySQL_Dat+";"+dbConnParam.mySQL_UID+";"+dbConnParam.mySQL_PWD);
                        connMySQL.Open();
                        MySql.Data.MySqlClient.MySqlCommand mySqlCommand = connMySQL.CreateCommand();
                        mySqlCommand.CommandText = cmd;
                        break;
                    default: throw new Exception("No Database, DbGetValue");
                        //break;
                }
                

            
            }

            /*----------------------------------AddParams----------------------------------*/

            public void CmdAddParam(string Param, object Value)
            {
                switch (dbConnParam.DbType)
                {
                    case 1:
                        SQLiteCommand cmd_sqlite = new SQLiteCommand();
                        cmd_sqlite.Parameters.AddWithValue(Param, Value);
                        break;
                    case 2:
                        MySql.Data.MySqlClient.MySqlCommand cmd_mysql = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd_mysql.Parameters.AddWithValue(Param, Value);
                        break;
                    default: throw new Exception("No Database, CmdAddParam");
                        //break;
                }
            }

            /*-----------------------------------GetData-----------------------------------*/

            /*
            conn = new SQLiteConnection(connectString);
            conn.Open();
                cmd = new SQLiteCommand();
            String sql = "SET IDENTITY_INSERT projTime OFF;";
            adapter = new SQLiteDataAdapter(sql, conn);
            sql = "SELECT * FROM projTime WHERE projID=" + projID;
                adapter = new SQLiteDataAdapter(sql, conn);
            ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
            */



























        }
    }
}
