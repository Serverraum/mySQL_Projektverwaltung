using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace howto_edit_picture_list
{
    public partial class PictureList : UserControl
    {
        public PictureList()
        {
            InitializeComponent();
        }
        public int projID = 0;
        /*--------- --------- --------- --- Fremdcode Beginn -- --------- --------- ---------*/
        /*--------- http://www.csharphelper.com/howtos/howto_edit_picture_list.html ---------*/
        // The currently loaded pictures.
        private List<Bitmap> Pictures = new List<Bitmap>();
        private const int PictureMargin = 8;

        // The index of the picture we clicked or
        // the picture before which we clicked.
        private int ClickedIndex = -1;
        private int pictureIndex;
        private void ArrangePanel()
        {
            panPictures.Controls.Clear();
            int x = PictureMargin;
            int y = PictureMargin;
            int i = 0;
            foreach (Bitmap picture in Pictures)
            {
                if (pictureIndex <= i)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    pic.Location = new Point(x, y);
                    pic.Image = picture;
                    pic.Visible = true;
                    pic.MouseDown += pic_MouseDown;
                    panPictures.Controls.Add(pic);

                    x += pic.Width + PictureMargin;
                };
                i++;
            }

            // Add one placeholder PictureBox.
            PictureBox placeholder = new PictureBox();
            placeholder.Location = new Point(x, y);
            placeholder.Size = new Size(0, 0);
            placeholder.Visible = true;
            placeholder.MouseDown += pic_MouseDown;
            panPictures.Controls.Add(placeholder);
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            // Ignore left mouse clicks.
            if (e.Button != MouseButtons.Right) return;

            // Display the context menu.
            PictureBox pic = sender as PictureBox;
            ShowContextMenu(new Point(pic.Left + e.X, pic.Top + e.Y));
        }

        private void panPictures_MouseDown(object sender, MouseEventArgs e)
        {
            // Ignore left mouse clicks.
            if (e.Button != MouseButtons.Right) return;

            // Display the context menu.
            ShowContextMenu(e.Location);
        }

        private void mnuMoveLeft_Click(object sender, EventArgs e)
        {
            if (pictureIndex > 0) { pictureIndex--; }
            //Bitmap bm = Pictures[ClickedIndex];
            //Pictures.RemoveAt(ClickedIndex);
            //Pictures.Insert(ClickedIndex - 1, bm);
            ArrangePanel();
        }

        private void mnuMoveRight_Click(object sender, EventArgs e)
        {
            if (pictureIndex < Pictures.Count()) { pictureIndex++; }
            //Bitmap bm = Pictures[ClickedIndex];
            //Pictures.RemoveAt(ClickedIndex);
            //Pictures.Insert(ClickedIndex + 1, bm);
            ArrangePanel();
        }

        private void mnuDeletePicture_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to delete this picture?",
                "Delete Picture?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeletePics(ClickedIndex);
                ArrangePanel();
            }
        }

        // Let the user insert a picture.
        private void mnuInsertPicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPicture.ShowDialog() == DialogResult.OK)
                {
                    int i = 0;
                    foreach (string filename in ofdPicture.FileNames)
                    {
                        Bitmap bm = new Bitmap(filename);
                        InsertPics(ClickedIndex + i, bm);
                        i++;
                    }
                    ArrangePanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Prepare the context menu and display it.
        private void ShowContextMenu(Point location)
        {
            // Assume we click after the final picture.
            bool clicked_on_picture = false;
            ClickedIndex = Pictures.Count - pictureIndex;

            // See if we clicked on or before a picture.
            int x = location.X + panPictures.HorizontalScroll.Value;
            //for (int i = 0; i < Pictures.Count; i++)
            for (int i = pictureIndex; i < Pictures.Count; i++)
            {
                // See if we are before the next picture.
                x -= PictureMargin;
                if (x < 0)
                {
                    ClickedIndex = i;
                    break;
                }

                // See if we are on this picture.
                x -= panPictures.Controls[(i - pictureIndex)].Width;
                if (x < 0)
                {
                    ClickedIndex = i;
                    clicked_on_picture = true;
                    break;
                }
            }

            // Enable and disable context menu items.
            mnuMoveLeft.Enabled =
                (clicked_on_picture && (ClickedIndex > 0));
            mnuMoveRight.Enabled =
                (clicked_on_picture && (ClickedIndex < Pictures.Count - 1));
            mnuDeletePicture.Enabled = clicked_on_picture;
            mnuInsertPicture.Enabled = !clicked_on_picture;

            // Display the context menu.
            ctxPictures.Show(panPictures, location);
        }
        /*--------- --------- --------- ---- Fremdcode Ende --- --------- --------- ---------*/

        private void bt_right_Click(object sender, EventArgs e)
        {

            if (pictureIndex < Pictures.Count() - 1) { pictureIndex++; }
            ArrangePanel();
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            if (pictureIndex > 0) { pictureIndex--; }
            ArrangePanel();
        }

        //Bitmap bm = new Bitmap(filename);
        //Pictures.Insert(ClickedIndex + i, bm);
        //     Bitmap bmp = new Bitmap(pictureBox2.Image);

        private void PictureList_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    //Bitmap bm = new Bitmap(Image.FromFile(files[0]));
                    //Pictures.Insert(ClickedIndex + i, bm);
                    ClickedIndex = Pictures.Count - pictureIndex;
                    int i = 0;
                    foreach (string file in files)
                    {
                        Bitmap bm = new Bitmap(file);
                        InsertPics(ClickedIndex + i, bm);
                        i++;
                    }
                    ArrangePanel();
                    //// Assign the first image to the picture variable.
                    //this.picture = Image.FromFile(files[0]);
                    //// Set the picture location equal to the drop point.
                    //this.pictureLocation = this.PointToClient(new Point(e.X, e.Y));
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

        private void PictureList_DragEnter(object sender, DragEventArgs e)
        {
            // If the data is a file or a bitmap, display the copy cursor.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) ||
               e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        public DateTime keyTime = new DateTime();

        private void panPictures_KeyDown(object sender, KeyEventArgs e)
        {
            if (((e.KeyCode == Keys.V && e.Control) || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) && keyTime.AddSeconds(0.2) < DateTime.Now) //Update screen only when needed; Add Slowness
            {
                if ((e.KeyCode == Keys.V && e.Control) && Clipboard.ContainsImage())
                {
                    ClickedIndex = Pictures.Count - pictureIndex;

                    Bitmap bm = new Bitmap(Clipboard.GetImage());
                    InsertPics(ClickedIndex, bm);
                }
                if (e.KeyCode == Keys.Left && pictureIndex > 0) { pictureIndex--; } //Left Key pushes Pics to left
                if (e.KeyCode == Keys.Right && pictureIndex < Pictures.Count() - 1) { pictureIndex++; } //Right Key pushes Pics to right
                ArrangePanel();
                keyTime = DateTime.Now;
            }

        }


        private void panPictures_Scroll(object sender, ScrollEventArgs e)
        {
 
                panPictures.Invalidate();
               
        }
        private void panPictures_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (keyTime.AddSeconds(0.05) < DateTime.Now)
            {
                // Update the drawing based upon the mouse wheel scrolling.
                panPictures.Invalidate();
                keyTime = DateTime.Now;
            }
        }

        private void panPictures_Resize(object sender, EventArgs e)
        {
            panPictures.Invalidate();
        }



        /*------ Insert Pics into DB and screen ------*/
        private void InsertPics(int index, Bitmap bm)
        {
            Pictures.Insert(index, bm);
            MessageBox.Show(projID.ToString() + ClickedIndex.ToString());
            //Do Database-Stuff
        }
        /*------ Remove Pics from DB and screen ------*/
        private void DeletePics(int index)
        {
            Pictures.RemoveAt(ClickedIndex);
            //Do Database-Stuff
            MessageBox.Show(projID.ToString() + ClickedIndex.ToString());
        }
        /*------ Load Pics from DB on ProjChange ------*/
        private void LoadPicsFromDB(int ProjID)
        {
            //On Load of Project, set local ProjID-Var and load Pics
            projID = ProjID;

        }

    }
}

