﻿using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Windows;
using System.Data;
using System.Data.SQLite;
//using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Diagnostics.Eventing.Reader;

namespace mySQL_Projektverwaltung
{
    public class DbConnParam
    {
        [JsonInclude]
        protected string SQLiteAddr;
        [JsonInclude]
        protected int DbType; //1 =  SQLite; 2 = mySQL
        [JsonInclude]
        protected string mySQL_Addr;//Address to Database
        [JsonInclude]
        protected string mySQL_Dat; //Database
        [JsonInclude]
        protected string mySQL_PWD; //Password
        [JsonInclude]
        protected string mySQL_UID; //Username
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

            internal DbConnParam dbConnParam = new DbConnParam();
            internal MySqlConnection connMySQL = new MySqlConnection();
            internal SQLiteConnection connSQLite = new SQLiteConnection();
            public SQLiteCommand cmdSQLite = new SQLiteCommand();
            internal MySqlCommand cmdMySQL = new MySqlCommand();
            internal SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter();
            internal MySqlDataAdapter MySqlAdapter = new MySqlDataAdapter();
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
                    MessageBox.Show("DB not configured", "Warning");
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

            /*-----------------------------------------------------------------------------*/
            /*         3 Steps to Success:                                                 */
            /* 1. Prepare: DbAddCmd(sql_command)                                         */
            /* 2. Add Params, if applicable: DbAddParams(paramname, param)                 */
            /* 3. Get Data:                                                                */
            /*      - DbDataAdapter (ToDo)                                                 */
            /*      - DbScalar() for single Items                                          */
            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------Prepare-----------------------------------*/

            public void DbAddCmd(string cmd)
            {
                switch (dbConnParam.DbType)
                {
                    case 1:
                        dbConnParam.DbType = 1;
                        SQLiteConnection connSQLite = new SQLiteConnection(dbConnParam.SQLiteAddr);
                        connSQLite.Open(); //open Connection
                        cmdSQLite = connSQLite.CreateCommand(); //create Command
                        cmdSQLite.CommandText = cmd; //Applying commandtext to Command
                        SQLiteAdapter = new SQLiteDataAdapter(cmd, connSQLite); //Also prepare DataAdapter, if needed for getting Dataset.
                        break;
                    case 2:
                        dbConnParam.DbType = 2; //same as above   +       Server=localhost;database=DapperDB;Uid=root;Pwd=;Charset=utf8;Port=3307;SslMode=none
                        
                        try
                        {
                            connMySQL = new MySqlConnection("server="+ dbConnParam.mySQL_Addr + ";uid=" + dbConnParam.mySQL_UID + ";pwd=" + dbConnParam.mySQL_PWD+";database=" + dbConnParam.mySQL_Dat);                                                              
                            connMySQL.Open();
                        } 
                        catch (MySqlException ex){
                            MessageBox.Show(ex.Message);
                        };
                        //connMySQL.Open();
                        cmdMySQL = connMySQL.CreateCommand();
                        cmdMySQL.CommandText = cmd;
                        MySqlAdapter = new MySqlDataAdapter(cmd, connMySQL);
                        break;
                    default: throw new Exception("No Database, DbAddCmd");
                        //break;
                }



            }

            /*----------------------------------AddParams----------------------------------*/

            public void CmdAddParam(string Param, object Value)
            {
                switch (dbConnParam.DbType)
                {
                    case 1:
                        //SQLiteCommand cmd_sqlite = new SQLiteCommand();
                        cmdSQLite.Parameters.AddWithValue(Param, Value);
                        break;
                    case 2:
                        //MySqlCommand cmd_mysql = new MySqlCommand();
                        cmdMySQL.Parameters.AddWithValue(Param, Value);
                        break;
                    default: throw new Exception("No Database, CmdAddParam");
                        //break;
                }
            }

            /*-----------------------------------GetData-----------------------------------*/
            public DataSet DbGetDataSet()
            {
                DataSet ds = new DataSet();
                switch (dbConnParam.DbType)
                {
                    case 1:
                        SQLiteAdapter.Fill(ds);
                        connSQLite.Close();
                        return ds;
                    case 2:
                        if (connMySQL.State != ConnectionState.Closed)
                        {
                            MySqlAdapter.Fill(ds);
                            connMySQL.Close();
                            return ds;
                        } else { return null; }
                    default:
                        throw new Exception("No DataBase");

                }
            }

            public DataTable DbGetDataTable()//Datatable 0
            {
                DataSet ds = DbGetDataSet();
                DataTable dt = ds.Tables[0];
                return dt;
            }

            public Object DbScalar()//Single Cell
            {
                switch (dbConnParam.DbType)
                {
                    case 1:
                        return cmdSQLite.ExecuteScalar();
                    case 2:
                        if(connMySQL.State != ConnectionState.Closed)
                        {
                            return cmdMySQL.ExecuteScalar(); } else { return null; }
                    default:
                        throw new Exception("No DataBase, ExecuteScalar");
                }
            }




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
            public void getData()
            {
                using (SQLiteDataReader reader = cmdSQLite.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        /*  RETURN DATA How?
                        cb_AG.Items.Add(reader.GetValue(2).ToString());
                        if (dtProj.Rows[0][3].ToString() == reader.GetValue(0).ToString())
                        {
                            cb_AG.SelectedIndex = i;

                        }
                        i++;  */
                    }
                }

                connSQLite.Close();
            }

           























        }
    }
}

