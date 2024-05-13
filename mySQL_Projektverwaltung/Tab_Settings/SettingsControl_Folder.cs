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
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mySQL_Projektverwaltung.SettingsControl_Folder;
using MySqlX.XDevAPI.Common;
using Google.Protobuf.WellKnownTypes;

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
            if (Directory.Exists(Settings.Instance.ProjFolder.MainFolder)) { dlg.InputPath = Settings.Instance.ProjFolder.MainFolder; } else { dlg.InputPath = @"C:\"; };
            //dlg.InputPath = Settings.Instance.projFolder.MainFolder;//@"c:\windows\system32";
            dlg.Title = "Select Main Project Folder";
            if (dlg.ShowDialog() == true)
            {
                MessageBox.Show(dlg.ResultPath);
                Settings.Instance.ProjFolder.MainFolder = dlg.ResultPath;
                tb_folder.Text = Settings.Instance.ProjFolder.MainFolder;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Settings.Instance.ProjFolder.ProjRegex = tb_regex.Text;
        }

        private void tb_regex_TextChanged(object sender, EventArgs e)
        {
            int textprojID = 12;

            string regextext = tb_regex.Text;
            

            lb_regex.Text = FolderRegex(regextext, textprojID); //Add true for Debug


        }

        public string FolderRegex(string regextext, int projID, bool debug = false)
        {
            string regexPattern = @"([[](?<group>[A-Za-z0-9]*)[\]])"; // [], [n], [M], [n5], ... werden gezählt.  Elemente innerhalb der Klammer werden als ${group}-Variable gespeichert.
            Regex regex = new Regex(regexPattern);
#if NET7_0_OR_GREATER
            int count = regex.Count(regextext);
#else

            int count = regex.Matches(regextext).Count();
#endif
            /*Debug*/
            string debugstr;
            debugstr = "Count: " + count.ToString();

            Match match = regex.Match(regextext);
            int i = 0;
            int regcnt = 0;
            while (i < count)
            {
                if (count > i && i > 0) { match = match.NextMatch(); }

                /*Debug*/ //Add found group
                debugstr = debugstr + "\r\nLenght: " + match.Length + "\r\nIndex: " + match.Index + "\r\n" + match.Result("${group}");


                /*Zahl mit n Leading Zeros*/
                Regex regex2 = new Regex("[n](?<nr>[1-9])");
                Match match2 = regex2.Match(match.Result("${group}"));
                if (match2.Success)
                {
                    int len = Int32.Parse(match2.Result("${nr}"));
                    string replacestr = projID.ToString("D" + len);
                    regextext = ReplaceFirst(regextext, match.Value, replacestr);
                    //regextext = regex.Replace(regextext, replacestr ,match.Length, match.Index);//-Replaces all matches
                    regcnt++;
                }
                /*Zahl*/
                else if (match.Result("${group}") == "n")
                {
                    string replacestr = projID.ToString();
                    regextext = ReplaceFirst(regextext, match.Value, replacestr);
                    //regextext = regex.Replace(regextext, replacestr, match.Length, match.Index);
                    regcnt++;
                }

                /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
                /*--- Place for more Regex-Stuff ---*/
                /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/





                i++;
            }
            if (count == 0 || regcnt == 0) //FALLBACK     (Zahl hintenangestellt)
            {
                regextext = regextext + projID.ToString();
            }

            debugstr =  debugstr + "\r\n" + regextext;

            switch (debug)
            {
                case false: return regextext;
                case true: return debugstr;
            }
        }
        public string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        private void SettingsControl_Folder_Load(object sender, EventArgs e)
        {
            tb_folder.Text = Settings.Instance.ProjFolder.MainFolder;
            tb_regex.Text = Settings.Instance.ProjFolder.ProjRegex;
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
        public ProjFolder ProjFolder { get; set; } = new ProjFolder();
    }

}
