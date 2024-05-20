namespace mySQL_Projektverwaltung.Tab_Project
{
    partial class Project_FolderControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            listView_projfolder = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            tb_folder = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button_LargeIcon = new System.Windows.Forms.Button();
            button_Details = new System.Windows.Forms.Button();
            button_SmallItem = new System.Windows.Forms.Button();
            button_Tile = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(54, 188);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(84, 55);
            button1.TabIndex = 0;
            button1.Text = "Change Project-Folder";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(68, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(296, 79);
            listBox1.TabIndex = 1;
            // 
            // listView_projfolder
            // 
            listView_projfolder.Location = new System.Drawing.Point(54, 249);
            listView_projfolder.Name = "listView_projfolder";
            listView_projfolder.Size = new System.Drawing.Size(391, 139);
            listView_projfolder.TabIndex = 2;
            listView_projfolder.UseCompatibleStateImageBehavior = false;
            listView_projfolder.View = System.Windows.Forms.View.List;
            listView_projfolder.DoubleClick += listView_projfolder_DoubleClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Incoming files: ";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(370, 49);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 47);
            button2.TabIndex = 4;
            button2.Text = "Download Files";
            button2.UseVisualStyleBackColor = true;
            // 
            // tb_folder
            // 
            tb_folder.Location = new System.Drawing.Point(144, 220);
            tb_folder.Name = "tb_folder";
            tb_folder.Size = new System.Drawing.Size(301, 23);
            tb_folder.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(159, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(266, 15);
            label2.TabIndex = 6;
            label2.Text = "(Max 15MB - MediumBLOB or 4 GB - LargeBLOB)";
            // 
            // button_LargeIcon
            // 
            button_LargeIcon.Location = new System.Drawing.Point(144, 159);
            button_LargeIcon.Name = "button_LargeIcon";
            button_LargeIcon.Size = new System.Drawing.Size(84, 55);
            button_LargeIcon.TabIndex = 7;
            button_LargeIcon.Text = "LargeItem";
            button_LargeIcon.UseVisualStyleBackColor = true;
            button_LargeIcon.Click += button_LargeIcon_Click;
            // 
            // button_Details
            // 
            button_Details.Location = new System.Drawing.Point(234, 159);
            button_Details.Name = "button_Details";
            button_Details.Size = new System.Drawing.Size(84, 55);
            button_Details.TabIndex = 8;
            button_Details.Text = "Details";
            button_Details.UseVisualStyleBackColor = true;
            button_Details.Click += button_Details_Click;
            // 
            // button_SmallItem
            // 
            button_SmallItem.Location = new System.Drawing.Point(324, 159);
            button_SmallItem.Name = "button_SmallItem";
            button_SmallItem.Size = new System.Drawing.Size(84, 55);
            button_SmallItem.TabIndex = 9;
            button_SmallItem.Text = "SmallItem";
            button_SmallItem.UseVisualStyleBackColor = true;
            button_SmallItem.Click += button_SmallItem_Click;
            // 
            // button_Tile
            // 
            button_Tile.Location = new System.Drawing.Point(414, 159);
            button_Tile.Name = "button_Tile";
            button_Tile.Size = new System.Drawing.Size(84, 55);
            button_Tile.TabIndex = 10;
            button_Tile.Text = "Tile";
            button_Tile.UseVisualStyleBackColor = true;
            button_Tile.Click += button_Tile_Click;
            // 
            // Project_FolderControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(button_Tile);
            Controls.Add(button_SmallItem);
            Controls.Add(button_Details);
            Controls.Add(button_LargeIcon);
            Controls.Add(label2);
            Controls.Add(tb_folder);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView_projfolder);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Project_FolderControl";
            Size = new System.Drawing.Size(516, 504);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView_projfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LargeIcon;
        private System.Windows.Forms.Button button_Details;
        private System.Windows.Forms.Button button_SmallItem;
        private System.Windows.Forms.Button button_Tile;
    }
}
