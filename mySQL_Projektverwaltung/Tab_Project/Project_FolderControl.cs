using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Windows.Shapes;
using RtfPipe;
using System.Security.AccessControl;
using System.Reflection.Metadata.Ecma335;
using CSharpLib;
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
        string folderprev; //Root Project Folder
        string folder; // Folder, where the user is, when he's in subdirectories
        bool FolderCreated;
        public void ReLoad_Project_FolderControl(int projId)
        {
            projID = projId;
            //Future: Check, if Files are available for Download. If yes, push Filenames into DownloadList and enable Download-Button.
            FolderCreated = false;

            ///Load Folder from DB
            ///If Cell "folder" empty, set prevFolder to Regex and check if folder exists; else set prevFolder to Cell "folder (from DB)
            /// string prevFolder = Regex OR Db[proj - folder]; bool FolderCreated = true|false 
            /// Set tb_folder to prevFolder
            ///
            ///On bool FolderCreated == true; load Files (and maybe also Subfolders) into Listview.
            listView_projfolder.Clear();
            //Load Folder From DB
            string sql = "SELECT folder FROM proj WHERE projID=@projID";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@projID", projId);
            folderprev = DbConnParam.DbConn.Instance.DbScalar().ToString();
            //If Cell "folder" empty, set prevFolder to Regex and check if folder exists;
            // else set prevFolder to Cell "folder (from DB)
            if (folderprev == null || folderprev == "")
            {
                SettingsControl_Folder cf = new SettingsControl_Folder();
                folderprev = cf.FolderRegex(Settings.Instance.ProjFolder.ProjRegex, projID);
                //check if created; On Error Do Nothing, Else LoadFiles
                //Check RootDirectory
                if (!Directory.Exists(Settings.Instance.ProjFolder.MainFolder)) { MessageBox.Show("Top Project Directory nonexistent! \r\n \r\n Change Topdir? \r\n Chancel?"); return; }
                //Check Proj-Subdir
                if (!Directory.Exists(Settings.Instance.ProjFolder.MainFolder + System.IO.Path.DirectorySeparatorChar + folderprev)) { return; };
                //Load Files + Add to DB
                sql = "UPDATE proj SET folder=@folder WHERE projID=@projID";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                DbConnParam.DbConn.Instance.CmdAddParam("@folder", Settings.Instance.ProjFolder.MainFolder + System.IO.Path.DirectorySeparatorChar + folderprev);
                int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("ProjFolder Successfully added");
                    folder = folderprev;
                    LoadFiles(Settings.Instance.ProjFolder.MainFolder + System.IO.Path.DirectorySeparatorChar + folderprev);
                }

                //LoadFiles(dir);
            }
            else
            {
                // check if created; On Error Show Message { Create-Folder; ChangeFolder; Clear[Reset Db[folder] to null or ""] }
                // Else LoadFiles(folderprev)
                if (!Directory.Exists(folderprev)) // -> Directory not found!!!
                {
                    bool ProblemSolved = false;
                    while (ProblemSolved == false)
                    {
                        using (var form = new ProjFolder_Missing())
                        {
                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                RETURN ret = form.ReturnValue;

                                MessageBox.Show(ret.ToString());
                                ///Create Folder
                                if (ret == RETURN.Create)
                                {
                                    Directory.CreateDirectory(folderprev);
                                    ProblemSolved = true;
                                };
                                if (ret == RETURN.Change)
                                {
                                    var dlg = new FolderPicker();
                                    if (Directory.Exists(Settings.Instance.ProjFolder.MainFolder)) { dlg.InputPath = Settings.Instance.ProjFolder.MainFolder; } else { dlg.InputPath = @"C:\"; };
                                    //dlg.InputPath = Settings.Instance.projFolder.MainFolder;//@"c:\windows\system32";
                                    dlg.Title = "Select Project Folder";
                                    if (dlg.ShowDialog() == true)
                                    {
                                        //MessageBox.Show(dlg.ResultPath);
                                        folderprev = dlg.ResultPath;
                                        sql = "UPDATE proj SET folder=@folder WHERE projID=@projID";
                                        DbConnParam.DbConn.Instance.DbAddCmd(sql);
                                        DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                                        DbConnParam.DbConn.Instance.CmdAddParam("@folder", Settings.Instance.ProjFolder.MainFolder + System.IO.Path.DirectorySeparatorChar + folderprev);
                                        int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
                                        if (i == 1)
                                        {
                                            MessageBox.Show("ProjFolder Successfully added");
                                            folder = folderprev;
                                            LoadFiles(Settings.Instance.ProjFolder.MainFolder + System.IO.Path.DirectorySeparatorChar + folderprev);
                                        }
                                        ProblemSolved = true;
                                    }
                                    
                                }
                                if (ret == RETURN.Reset)
                                {
                                    sql = "UPDATE proj SET folder=@folder WHERE projID=@projID";
                                    DbConnParam.DbConn.Instance.DbAddCmd(sql);
                                    DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                                    DbConnParam.DbConn.Instance.CmdAddParam("@folder", null);
                                    int i = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
                                    if (i == 1)
                                    {
                                        MessageBox.Show("ProjFolder Successfully Resetted");
                                        
                                    }
                                    ProblemSolved = true;
                                }
                            }

                        }
                    }

                    //Yes Create No Change Retry Reset
                }
                folder = folderprev;
                LoadFiles(folderprev);
            }
        }

        // Drag'n'Drop: On bool FolderCreated == false, create Folder. Then regardless of FolderCreated push File into folder
        // Same for Download and



        public void LoadFiles(string dirstr, bool WithoutClear = false)
        {
            DirectoryInfo topdir = new DirectoryInfo(dirstr);
            DirectoryInfo[] subdirs = topdir.GetDirectories();
            FileInfo[] subfiles = topdir.GetFiles();

            if (!WithoutClear) { listView_projfolder.Clear(); }
            listView_projfolder.Columns.Add("Name", "Name");
            listView_projfolder.Columns.Add("Changed", "Changed");
            listView_projfolder.Columns.Add("Size", "Size");
            if (listView_projfolder.SmallImageList is not null) { listView_projfolder.SmallImageList.Dispose(); }
            int i = 0;
            foreach (DirectoryInfo dir in subdirs)
            {
                ListViewHelper.AddItemToListView(listView_projfolder, dir.FullName, i);
                i++;
            }
            foreach (FileInfo file in subfiles)
            {
                ListViewHelper.AddItemToListView(listView_projfolder, file.FullName, i);
                i++;
            }
            //ListViewHelper.AddItemToListView(yourListView, "C:\\example\\example.txt");
            //ListViewHelper.AddItemToListView(yourListView, "C:\\example\\exampleFolder");

        }


        private void listView_projfolder_DoubleClick_1(object sender, EventArgs e)
        {
            var item = listView_projfolder.SelectedItems[0];
            if (item != null)
            {
                //MessageBox.Show(item.Tag.ToString());
                if (item.Tag.ToString() == "FileTop")
                {
                    //MessageBox.Show("TopFolder");
                    folder = Directory.GetParent(folder).ToString();
                    listView_projfolder.Clear();
                    if (folder != folderprev) //Maybe convert locally to DirectoryInfo to check, if it's the same folder.
                    {
                        //Add Back-Document
                        ListViewItem BackDir = new ListViewItem();
                        BackDir.Tag = "FileTop"; // or any other object
                        BackDir.Text = "Back";
                        //myItem.ImageIndex = count;

                        //if (listView.LargeImageList is null) { listView.LargeImageList = new ImageList(); }
                        ////Bitmap imageL = WindowsThumbnailProvider.GetThumbnail(path, 256, 256, ThumbnailOptions.BiggerSizeOk);
                        //if (imageL != null) { listView.LargeImageList.Images.Add(path, imageL); } else { listView.LargeImageList.Images.Add(path, image); }
                        ////listView.LargeImageList.Images.Add(path,image);
                        //listView.SmallImageList.Images.Add(path, image);

                        listView_projfolder.Items.Add(BackDir);
                    }

                    LoadFiles(folder, true);
                    return;
                }
                if (Directory.Exists(item.Tag.ToString()))
                {
                    //MessageBox.Show("Dir: " + item.Tag.ToString());
                    //Add Back-Document
                    ListViewItem BackDir = new ListViewItem();
                    BackDir.Tag = "FileTop"; // or any other object
                    BackDir.Text = "Back";
                    //myItem.ImageIndex = count;

                    //if (listView.LargeImageList is null) { listView.LargeImageList = new ImageList(); }
                    ////Bitmap imageL = WindowsThumbnailProvider.GetThumbnail(path, 256, 256, ThumbnailOptions.BiggerSizeOk);
                    //if (imageL != null) { listView.LargeImageList.Images.Add(path, imageL); } else { listView.LargeImageList.Images.Add(path, image); }
                    ////listView.LargeImageList.Images.Add(path,image);
                    //listView.SmallImageList.Images.Add(path, image);
                    folder = item.Tag.ToString();
                    listView_projfolder.Clear();
                    listView_projfolder.Items.Add(BackDir);
                    LoadFiles(folder, true);
                    return;
                }

                ///Start File

                if (File.Exists(item.Tag.ToString()))
                {
                    MessageBox.Show("File: " + item.Tag.ToString());
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = @item.Tag.ToString()/*@"http://. . . ."*/, UseShellExecute = true });
                    return;
                }

            }
        }

        private void button_LargeIcon_Click(object sender, EventArgs e)
        {
            listView_projfolder.View = View.LargeIcon;
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            listView_projfolder.View = View.Details;
        }

        private void button_SmallItem_Click(object sender, EventArgs e)
        {
            listView_projfolder.View = View.SmallIcon;
        }

        private void button_Tile_Click(object sender, EventArgs e)
        {
            listView_projfolder.View = View.Tile;
        }



        private void Folder_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    switch (FolderCreated)
                    {
                        case true: break; // Folder already created
                        case false:
                            try
                            {
                                Directory.CreateDirectory(folderprev);
                                FolderCreated = true;
                                string sql = "UPDATE proj SET folder=@folder WHERE projID=@projID";
                                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                                DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                                DbConnParam.DbConn.Instance.CmdAddParam("@folder", folderprev);
                                int y = DbConnParam.DbConn.Instance.DbExecuteNonQuery();
                                if (y == 1)
                                {
                                    MessageBox.Show("ProjFolder Successfully added");
                                    folder = folderprev;
                                    LoadFiles(folderprev);
                                }
                            }
                            catch (Exception) { throw; }
                            break;
                    }


                    int i = 0;
                    foreach (string file in files)
                    {
                        if (File.Exists(file))
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            if (File.Exists(folder + System.IO.Path.DirectorySeparatorChar + fileInfo.Name))
                            {
                                int x = 1;
                                while (File.Exists(folder + System.IO.Path.DirectorySeparatorChar + fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length) + "(" + x.ToString() + ")" + fileInfo.Extension)) { x++; }
                                System.IO.File.Copy(file, folder + System.IO.Path.DirectorySeparatorChar + fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length) + "(" + x.ToString() + ")" + fileInfo.Extension);
                            }
                            else System.IO.File.Copy(file, folder + System.IO.Path.DirectorySeparatorChar + fileInfo.Name);
                        }
                        else if (Directory.Exists(file))
                        {
                            DirectoryInfo directoryInfo = new DirectoryInfo(file);
                            if (Directory.Exists(folder + System.IO.Path.DirectorySeparatorChar + directoryInfo.Name))
                            {
                                int x = 1;
                                while (Directory.Exists(folder + System.IO.Path.DirectorySeparatorChar + directoryInfo.Name + "(" + x.ToString() + ")")) { x++; }
                                //System.IO.Directory.Copy(file, folder + System.IO.Path.DirectorySeparatorChar + directoryInfo.Name + "(" + x.ToString() + ")");
                                CopyDirectory(@file, folder + System.IO.Path.DirectorySeparatorChar + directoryInfo.Name + "(" + x.ToString() + ")", true);
                            }
                            else CopyDirectory(@file, folder + System.IO.Path.DirectorySeparatorChar + directoryInfo.Name, true);
                        }

                        i++;
                    }
                    LoadFiles(folder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            /*
            // Handle Bitmap data.
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                try
                {
                    // Create an Image and assign it to the picture variable.
                    this.picture = (Image)e.Data.GetData(DataFormats.Bitmap);
                    // Set the picture location equal to the drop point.
                    this.pictureLocation = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            // Force the form to be redrawn with the image.
            this.Invalidate();*/
        }

        private void Folder_DragEnter(object sender, DragEventArgs e)
        {

            // If the data is a file, display the copy cursor.
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = System.IO.Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = System.IO.Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
    }


    /*------ ------ ------ HELPER Functions ------ ------ ------*/
    public class ListViewHelper
    {
        /// <summary>
        /// Comment
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="path"></param>
        /// <param name="count"></param>
        public static void AddItemToListView(ListView listView, string path, int count = 0)
        {
            Bitmap image = WindowsThumbnailProvider.GetThumbnail(path, 32, 32, ThumbnailOptions.BiggerSizeOk);
            if (image != null)
            {
                if (listView.SmallImageList is null) { listView.SmallImageList = new ImageList(); }
                //create new Tag
                ListViewItem myItem = new ListViewItem();
                myItem.Tag = path; // or any other object
                myItem.Text = System.IO.Path.GetFileName(path);
                myItem.ImageIndex = count;

                ///Add SUB-Details for DetailView
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(myItem, "Changed");
                subItem.Name = "Changed";
                string date = "";
                switch (Convert.ToInt16(Directory.Exists(path)) + Convert.ToInt16(File.Exists(path)) * 2)
                {
                    case 1: DateTime dt = Directory.GetLastWriteTime(path); date = dt.ToShortDateString(); break;
                    case 2: dt = File.GetLastWriteTime(path); date = dt.ToShortDateString(); break;
                    default: MessageBox.Show("Error. Case either 0 or >2"); break;
                }
                subItem.Text = "" + date;
                myItem.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(myItem, "FileSize");
                subItem.Name = "FileSize";
                FileInfo fileInfo;
                DirectoryInfo directoryInfo;
                string lenght;
                switch (Convert.ToInt16(Directory.Exists(path)) + Convert.ToInt16(File.Exists(path)) * 2)
                {
                    case 1: directoryInfo = new DirectoryInfo(path); lenght = directoryInfo.FormatBytes(); break;
                    case 2: fileInfo = new FileInfo(path); lenght = fileInfo.FormatBytes(); break;
                    default: lenght = ""; break;
                }
                switch (lenght == "0 B")
                {
                    case true: lenght = ""; break;
                }
                subItem.Text = "" + lenght;
                myItem.SubItems.Add(subItem);
                //myItem.SubItems.Add(System.IO.Path.GetFileName(path));
                //myItem.SubItems.Add("12.12.2021");
                ///**




                if (listView.LargeImageList is null) { listView.LargeImageList = new ImageList(); Size s = new Size(); s.Width = 64; s.Height = 64; listView.LargeImageList.ImageSize = s; }
                Bitmap imageL = WindowsThumbnailProvider.GetThumbnail(path, 256, 256, ThumbnailOptions.None);
                if (imageL != null) { listView.LargeImageList.Images.Add(path, imageL); }// else { listView.LargeImageList.Images.Add(path, image); }
                                                                                         //listView.LargeImageList.Images.Add(path,image);
                listView.SmallImageList.Images.Add(path, image);
                listView.Items.Add(myItem);
            }
        }
    }




    /*________________________________________________-*/
    /// <summary>
    /// Code by snickers; 2017, Stackoverflow
    /// https://stackoverflow.com/questions/21751747/extract-thumbnail-for-any-file-in-windows/42178963#42178963
    /// </summary>
    [Flags]
    public enum ThumbnailOptions
    {
        None = 0x00,
        BiggerSizeOk = 0x01,
        InMemoryOnly = 0x02,
        IconOnly = 0x04,
        ThumbnailOnly = 0x08,
        InCacheOnly = 0x10
    }

    public class WindowsThumbnailProvider
    {
        private const string IShellItem2Guid = "7E9FB0D3-919F-4307-AB2E-9B1860310C93";

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern int SHCreateItemFromParsingName(
            [MarshalAs(UnmanagedType.LPWStr)] string path,
            // The following parameter is not used - binding context.
            IntPtr pbc,
            ref Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out IShellItem shellItem);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr hObject);

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe IntPtr memcpy(void* dst, void* src, UIntPtr count);

        public static Bitmap GetThumbnail(string fileName, int width, int height, ThumbnailOptions options)
        {
            var hBitmap = GetHBitmap(System.IO.Path.GetFullPath(fileName), width, height, options);

            try
            {
                // return a System.Drawing.Bitmap from the hBitmap
                return GetBitmapFromHBitmap(hBitmap);
            }
            finally
            {
                // delete HBitmap to avoid memory leaks
                DeleteObject(hBitmap);
            }
        }

        public static Bitmap GetBitmapFromHBitmap(IntPtr nativeHBitmap)
        {
            Bitmap bmp = Image.FromHbitmap(nativeHBitmap);

            if (Image.GetPixelFormatSize(bmp.PixelFormat) < 32)
                return bmp;

            using (bmp)
                return CreateAlphaBitmap(bmp, PixelFormat.Format32bppArgb);
        }

        public static unsafe Bitmap CreateAlphaBitmap(Bitmap srcBitmap, PixelFormat targetPixelFormat)
        {
            var result = new Bitmap(srcBitmap.Width, srcBitmap.Height, targetPixelFormat);

            var bmpBounds = new System.Drawing.Rectangle(0, 0, srcBitmap.Width, srcBitmap.Height);
            var srcData = srcBitmap.LockBits(bmpBounds, ImageLockMode.ReadOnly, srcBitmap.PixelFormat);
            var destData = result.LockBits(bmpBounds, ImageLockMode.ReadOnly, targetPixelFormat);

            var srcDataPtr = (byte*)srcData.Scan0;
            var destDataPtr = (byte*)destData.Scan0;

            try
            {
                for (int y = 0; y <= srcData.Height - 1; y++)
                {
                    for (int x = 0; x <= srcData.Width - 1; x++)
                    {
                        //this is really important because one stride may be positive and the other negative
                        var position = srcData.Stride * y + 4 * x;
                        var position2 = destData.Stride * y + 4 * x;

                        memcpy(destDataPtr + position2, srcDataPtr + position, (UIntPtr)4);
                    }
                }
            }
            finally
            {
                srcBitmap.UnlockBits(srcData);
                result.UnlockBits(destData);
            }

            return result;
        }

        private static IntPtr GetHBitmap(string fileName, int width, int height, ThumbnailOptions options)
        {
            IShellItem nativeShellItem;
            Guid shellItem2Guid = new Guid(IShellItem2Guid);
            int retCode = SHCreateItemFromParsingName(fileName, IntPtr.Zero, ref shellItem2Guid, out nativeShellItem);

            if (retCode != 0)
                throw Marshal.GetExceptionForHR(retCode);

            NativeSize nativeSize = new NativeSize();
            nativeSize.Width = width;
            nativeSize.Height = height;

            IntPtr hBitmap;
            HResult hr = ((IShellItemImageFactory)nativeShellItem).GetImage(nativeSize, options, out hBitmap);

            Marshal.ReleaseComObject(nativeShellItem);

            if (hr == HResult.Ok) return hBitmap;

            throw Marshal.GetExceptionForHR((int)hr);
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("43826d1e-e718-42ee-bc55-a1e261c37bfe")]
        internal interface IShellItem
        {
            void BindToHandler(IntPtr pbc,
                [MarshalAs(UnmanagedType.LPStruct)] Guid bhid,
                [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
                out IntPtr ppv);

            void GetParent(out IShellItem ppsi);
            void GetDisplayName(SIGDN sigdnName, out IntPtr ppszName);
            void GetAttributes(uint sfgaoMask, out uint psfgaoAttribs);
            void Compare(IShellItem psi, uint hint, out int piOrder);
        }

        internal enum SIGDN : uint
        {
            NORMALDISPLAY = 0,
            PARENTRELATIVEPARSING = 0x80018001,
            PARENTRELATIVEFORADDRESSBAR = 0x8001c001,
            DESKTOPABSOLUTEPARSING = 0x80028000,
            PARENTRELATIVEEDITING = 0x80031001,
            DESKTOPABSOLUTEEDITING = 0x8004c000,
            FILESYSPATH = 0x80058000,
            URL = 0x80068000
        }

        internal enum HResult
        {
            Ok = 0x0000,
            False = 0x0001,
            InvalidArguments = unchecked((int)0x80070057),
            OutOfMemory = unchecked((int)0x8007000E),
            NoInterface = unchecked((int)0x80004002),
            Fail = unchecked((int)0x80004005),
            ElementNotFound = unchecked((int)0x80070490),
            TypeElementNotFound = unchecked((int)0x8002802B),
            NoObject = unchecked((int)0x800401E5),
            Win32ErrorCanceled = 1223,
            Canceled = unchecked((int)0x800704C7),
            ResourceInUse = unchecked((int)0x800700AA),
            AccessDenied = unchecked((int)0x80030005)
        }

        [ComImport]
        [Guid("bcc18b79-ba16-442f-80c4-8a59c30c463b")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IShellItemImageFactory
        {
            [PreserveSig]
            HResult GetImage(
                [In, MarshalAs(UnmanagedType.Struct)] NativeSize size,
                [In] ThumbnailOptions flags,
                [Out] out IntPtr phbm);
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct NativeSize
        {
            private int width;
            private int height;

            public int Width
            {
                set { width = value; }
            }

            public int Height
            {
                set { height = value; }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }
    }
}