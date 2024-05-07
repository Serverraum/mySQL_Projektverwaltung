using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mySQL_Projektverwaltung.SettingsControl_Folder;

namespace mySQL_Projektverwaltung
{

    public partial class SettingsControl_Folder : UserControl
    {
        public SettingsControl_Folder()
        {
            InitializeComponent();
        }

        private void bt_folder_Click(object sender, EventArgs e) //Set Main Folder Path
        {
            var dlg = new FolderPicker();
            if (Directory.Exists(Settings.Instance.projFolder.MainFolder)) { dlg.InputPath = Settings.Instance.projFolder.MainFolder; } else { dlg.InputPath = @"C:\"; };
            //dlg.InputPath = Settings.Instance.projFolder.MainFolder;//@"c:\windows\system32";
            dlg.Title = "Select Main Project Folder";
            if (dlg.ShowDialog() == true)
            {
                MessageBox.Show(dlg.ResultPath);
                Settings.Instance.projFolder.MainFolder = dlg.ResultPath;
                tb_folder.Text = Settings.Instance.projFolder.MainFolder;
            }
        }

    }

    public class ProjFolder
    {
        [JsonInclude]
        public string MainFolder = "C:\\";
        [JsonInclude]
        public string ProjRegex = "Projekt";
    }
    public sealed partial class Settings
    {
        public ProjFolder projFolder { get; set; } = new ProjFolder();
    }

}
