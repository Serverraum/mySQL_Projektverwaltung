using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySQL_Projektverwaltung.Tab_Settings
{
    public partial class SettingsControl_Folder : UserControl
    {
        protected string configFilePath = "configfolder.json";
        public class ProjFolder
        {
            public string MainFolder = "";
            public string ProjRegex = "";
        }
        
        public SettingsControl_Folder()
        {
            InitializeComponent();
        }/*
        public void connLoadParam()// Load Param from JSON
        {

            try
            {
                string json = File.ReadAllText(path: configFilePath);
                dbConnParam = JsonSerializer.Deserialize<DbConnParam>(json);
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

        */
    }
}
