namespace mySQL_Projektverwaltung
{
    partial class Main
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            splitContainer_horiz_left = new System.Windows.Forms.SplitContainer();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label10 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            project_MainControl1 = new Tab_Project.Project_MainControl();
            splitContainer_horiz_right = new System.Windows.Forms.SplitContainer();
            splitContainer_mid_horiz = new System.Windows.Forms.SplitContainer();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            splitContainer_right_vert = new System.Windows.Forms.SplitContainer();
            pictureList1 = new howto_edit_picture_list.PictureList();
            project_TimeControl1 = new Project_TimeControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button3 = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            settingsControl1 = new SettingsControl();
            tb_DB_File = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            Button_SetDB = new System.Windows.Forms.Button();
            project_FolderControl1 = new Tab_Project.Project_FolderControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_horiz_left).BeginInit();
            splitContainer_horiz_left.Panel1.SuspendLayout();
            splitContainer_horiz_left.Panel2.SuspendLayout();
            splitContainer_horiz_left.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_horiz_right).BeginInit();
            splitContainer_horiz_right.Panel1.SuspendLayout();
            splitContainer_horiz_right.Panel2.SuspendLayout();
            splitContainer_horiz_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_mid_horiz).BeginInit();
            splitContainer_mid_horiz.Panel1.SuspendLayout();
            splitContainer_mid_horiz.Panel2.SuspendLayout();
            splitContainer_mid_horiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_right_vert).BeginInit();
            splitContainer_right_vert.Panel1.SuspendLayout();
            splitContainer_right_vert.Panel2.SuspendLayout();
            splitContainer_right_vert.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            tableLayoutPanel1.SetColumnSpan(button2, 2);
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Location = new System.Drawing.Point(8, 8);
            button2.Margin = new System.Windows.Forms.Padding(8);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(175, 212);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new System.Drawing.Size(963, 613);
            tabControl1.TabIndex = 8;
            tabControl1.Click += Main_Load;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(splitContainer_horiz_left);
            tabPage1.Location = new System.Drawing.Point(4, 27);
            tabPage1.Margin = new System.Windows.Forms.Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2);
            tabPage1.Size = new System.Drawing.Size(955, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Auftrag/Projekt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer_horiz_left
            // 
            splitContainer_horiz_left.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_horiz_left.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer_horiz_left.IsSplitterFixed = true;
            splitContainer_horiz_left.Location = new System.Drawing.Point(2, 2);
            splitContainer_horiz_left.Name = "splitContainer_horiz_left";
            // 
            // splitContainer_horiz_left.Panel1
            // 
            splitContainer_horiz_left.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer_horiz_left.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_horiz_left.Panel1MinSize = 200;
            // 
            // splitContainer_horiz_left.Panel2
            // 
            splitContainer_horiz_left.Panel2.Controls.Add(splitContainer_horiz_right);
            splitContainer_horiz_left.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_horiz_left.Panel2MinSize = 100;
            splitContainer_horiz_left.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_horiz_left.Size = new System.Drawing.Size(951, 578);
            splitContainer_horiz_left.SplitterDistance = 200;
            splitContainer_horiz_left.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.49531F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.49532F));
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Controls.Add(button4, 1, 0);
            tableLayoutPanel2.Controls.Add(project_MainControl1, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            tableLayoutPanel2.Size = new System.Drawing.Size(200, 578);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(2, 7);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(95, 15);
            label10.TabIndex = 19;
            label10.Text = "ProjID(Vorläufig)";
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button4.AutoSize = true;
            button4.Location = new System.Drawing.Point(101, 2);
            button4.Margin = new System.Windows.Forms.Padding(2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(97, 25);
            button4.TabIndex = 19;
            button4.Text = "Proj.-Wahl";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // project_MainControl1
            // 
            project_MainControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            project_MainControl1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(project_MainControl1, 2);
            project_MainControl1.Location = new System.Drawing.Point(3, 33);
            project_MainControl1.MinimumSize = new System.Drawing.Size(150, 440);
            project_MainControl1.Name = "project_MainControl1";
            project_MainControl1.Size = new System.Drawing.Size(194, 542);
            project_MainControl1.TabIndex = 20;
            // 
            // splitContainer_horiz_right
            // 
            splitContainer_horiz_right.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_horiz_right.Location = new System.Drawing.Point(0, 0);
            splitContainer_horiz_right.Name = "splitContainer_horiz_right";
            // 
            // splitContainer_horiz_right.Panel1
            // 
            splitContainer_horiz_right.Panel1.Controls.Add(splitContainer_mid_horiz);
            splitContainer_horiz_right.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_horiz_right.Panel1MinSize = 100;
            // 
            // splitContainer_horiz_right.Panel2
            // 
            splitContainer_horiz_right.Panel2.Controls.Add(splitContainer_right_vert);
            splitContainer_horiz_right.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_horiz_right.Panel2MinSize = 150;
            splitContainer_horiz_right.Size = new System.Drawing.Size(747, 578);
            splitContainer_horiz_right.SplitterDistance = 223;
            splitContainer_horiz_right.TabIndex = 0;
            // 
            // splitContainer_mid_horiz
            // 
            splitContainer_mid_horiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainer_mid_horiz.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_mid_horiz.Location = new System.Drawing.Point(0, 0);
            splitContainer_mid_horiz.Name = "splitContainer_mid_horiz";
            splitContainer_mid_horiz.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_mid_horiz.Panel1
            // 
            splitContainer_mid_horiz.Panel1.Controls.Add(richTextBox1);
            splitContainer_mid_horiz.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_mid_horiz.Panel1MinSize = 100;
            // 
            // splitContainer_mid_horiz.Panel2
            // 
            splitContainer_mid_horiz.Panel2.Controls.Add(project_FolderControl1);
            splitContainer_mid_horiz.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_mid_horiz.Panel2MinSize = 100;
            splitContainer_mid_horiz.Size = new System.Drawing.Size(223, 578);
            splitContainer_mid_horiz.SplitterDistance = 124;
            splitContainer_mid_horiz.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(221, 122);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // splitContainer_right_vert
            // 
            splitContainer_right_vert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainer_right_vert.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_right_vert.Location = new System.Drawing.Point(0, 0);
            splitContainer_right_vert.Name = "splitContainer_right_vert";
            splitContainer_right_vert.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_right_vert.Panel1
            // 
            splitContainer_right_vert.Panel1.Controls.Add(pictureList1);
            splitContainer_right_vert.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_right_vert.Panel1MinSize = 100;
            // 
            // splitContainer_right_vert.Panel2
            // 
            splitContainer_right_vert.Panel2.Controls.Add(project_TimeControl1);
            splitContainer_right_vert.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer_right_vert.Panel2MinSize = 50;
            splitContainer_right_vert.Size = new System.Drawing.Size(520, 578);
            splitContainer_right_vert.SplitterDistance = 100;
            splitContainer_right_vert.TabIndex = 0;
            // 
            // pictureList1
            // 
            pictureList1.AutoSize = true;
            pictureList1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureList1.Location = new System.Drawing.Point(0, 0);
            pictureList1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureList1.MinimumSize = new System.Drawing.Size(152, 58);
            pictureList1.Name = "pictureList1";
            pictureList1.Size = new System.Drawing.Size(518, 98);
            pictureList1.TabIndex = 21;
            // 
            // project_TimeControl1
            // 
            project_TimeControl1.AutoSize = true;
            project_TimeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            project_TimeControl1.Location = new System.Drawing.Point(0, 0);
            project_TimeControl1.Name = "project_TimeControl1";
            project_TimeControl1.Size = new System.Drawing.Size(518, 472);
            project_TimeControl1.TabIndex = 19;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new System.Drawing.Point(4, 27);
            tabPage2.Margin = new System.Windows.Forms.Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(2);
            tabPage2.Size = new System.Drawing.Size(817, 544);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Übersicht";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(7, 15);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(191, 457);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button3.Location = new System.Drawing.Point(8, 236);
            button3.Margin = new System.Windows.Forms.Padding(8);
            button3.MaximumSize = new System.Drawing.Size(0, 80);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(79, 80);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(settingsControl1);
            tabPage3.Controls.Add(tb_DB_File);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(Button_SetDB);
            tabPage3.Location = new System.Drawing.Point(4, 27);
            tabPage3.Margin = new System.Windows.Forms.Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(817, 544);
            tabPage3.TabIndex = 2;
            tabPage3.Tag = "dbConn";
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // settingsControl1
            // 
            settingsControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            settingsControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            settingsControl1.Location = new System.Drawing.Point(9, 99);
            settingsControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            settingsControl1.MinimumSize = new System.Drawing.Size(259, 316);
            settingsControl1.Name = "settingsControl1";
            settingsControl1.Size = new System.Drawing.Size(259, 316);
            settingsControl1.TabIndex = 3;
            // 
            // tb_DB_File
            // 
            tb_DB_File.Enabled = false;
            tb_DB_File.ImeMode = System.Windows.Forms.ImeMode.On;
            tb_DB_File.Location = new System.Drawing.Point(51, 27);
            tb_DB_File.Margin = new System.Windows.Forms.Padding(2);
            tb_DB_File.Name = "tb_DB_File";
            tb_DB_File.Size = new System.Drawing.Size(655, 23);
            tb_DB_File.TabIndex = 2;
            tb_DB_File.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 9);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(114, 15);
            label8.TabIndex = 1;
            label8.Text = "Pfad der Datenbank:";
            // 
            // Button_SetDB
            // 
            Button_SetDB.Location = new System.Drawing.Point(9, 27);
            Button_SetDB.Margin = new System.Windows.Forms.Padding(2);
            Button_SetDB.Name = "Button_SetDB";
            Button_SetDB.Size = new System.Drawing.Size(36, 22);
            Button_SetDB.TabIndex = 0;
            Button_SetDB.Text = "DB";
            Button_SetDB.UseVisualStyleBackColor = true;
            Button_SetDB.Click += Button_SetDB_Click;
            // 
            // project_FolderControl1
            // 
            project_FolderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            project_FolderControl1.Location = new System.Drawing.Point(0, 0);
            project_FolderControl1.Name = "project_FolderControl1";
            project_FolderControl1.Size = new System.Drawing.Size(221, 448);
            project_FolderControl1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(963, 613);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(231, 107);
            Name = "Main";
            Text = "Form1";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer_horiz_left.Panel1.ResumeLayout(false);
            splitContainer_horiz_left.Panel1.PerformLayout();
            splitContainer_horiz_left.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_horiz_left).EndInit();
            splitContainer_horiz_left.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            splitContainer_horiz_right.Panel1.ResumeLayout(false);
            splitContainer_horiz_right.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_horiz_right).EndInit();
            splitContainer_horiz_right.ResumeLayout(false);
            splitContainer_mid_horiz.Panel1.ResumeLayout(false);
            splitContainer_mid_horiz.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_mid_horiz).EndInit();
            splitContainer_mid_horiz.ResumeLayout(false);
            splitContainer_right_vert.Panel1.ResumeLayout(false);
            splitContainer_right_vert.Panel1.PerformLayout();
            splitContainer_right_vert.Panel2.ResumeLayout(false);
            splitContainer_right_vert.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_right_vert).EndInit();
            splitContainer_right_vert.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_DB_File;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_SetDB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private SettingsControl settingsControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Tab_Project.Project_MainControl project_MainControl1;
        private Project_TimeControl project_TimeControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private howto_edit_picture_list.PictureList pictureList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer_horiz_left;
        private System.Windows.Forms.SplitContainer splitContainer_horiz_right;
        private System.Windows.Forms.SplitContainer splitContainer_mid_horiz;
        private System.Windows.Forms.SplitContainer splitContainer_right_vert;
        private Tab_Project.Project_FolderControl project_FolderControl1;
    }
}

