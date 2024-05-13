using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
//  Hard Connection to/from:                 //
//   - MainProj    (project_MainControl1)    //
//   (For Save-Function)                     //
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
namespace mySQL_Projektverwaltung.Tab_Project
{
    public partial class Project_FolderControl : UserControl
    {
        public Project_FolderControl()
        {
            InitializeComponent();
            setctrl.FolderRegex(Settings.Instance.ProjFolder.ProjRegex, projID);
        }
        SettingsControl_Folder setctrl = new SettingsControl_Folder();
        int projID;

        public void ReLoad_Project_FolderControl(int projId)
        {
            projId = projID;
            //Future: Check, if Files are available for Download. If yes, push Filenames into DownloadList and enable Download-Button.


            //Load Folder from DB
            //If Cell "folder" empty, set prevFolder to Regex and check if folder exists; else set prevFolder to Cell "folder (from DB)
            // string prevFolder = Regex OR Db[proj - folder]; bool FolderCreated = true|false 
            // Set tb_folder to prevFolder
            //
            //On bool FolderCreated == true; load Files (and maybe also Subfolders) into Listview.
        }       
        // Drag'n'Drop: On bool FolderCreated == false, create Folder. Then regardless of FolderCreated push File into folder
        // Same for Download and
        
    }
}
