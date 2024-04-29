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
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            button2 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            button4 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBox2 = new System.Windows.Forms.GroupBox();
            fileNameLabel = new System.Windows.Forms.Label();
            fileTypeLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tb_filepath = new System.Windows.Forms.TextBox();
            listView1 = new System.Windows.Forms.ListView();
            project_TimeControl1 = new Project_TimeControl();
            label9 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button3 = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            settingsControl1 = new SettingsControl();
            tb_DB_File = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            Button_SetDB = new System.Windows.Forms.Button();
            project_MainControl1 = new Tab_Project.Project_MainControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            richTextBox1.Location = new System.Drawing.Point(5, 133);
            richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(333, 111);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            tableLayoutPanel1.SetColumnSpan(button2, 2);
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Location = new System.Drawing.Point(8, 8);
            button2.Margin = new System.Windows.Forms.Padding(8);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(175, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(147, 48);
            listBox1.Margin = new System.Windows.Forms.Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(106, 79);
            listBox1.TabIndex = 6;
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
            tabControl1.Size = new System.Drawing.Size(1037, 588);
            tabControl1.TabIndex = 8;
            tabControl1.Click += Main_Load;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(project_MainControl1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new System.Drawing.Point(4, 27);
            tabPage1.Margin = new System.Windows.Forms.Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2);
            tabPage1.Size = new System.Drawing.Size(1029, 557);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Auftrag/Projekt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(130, 7);
            button4.Margin = new System.Windows.Forms.Padding(2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(89, 22);
            button4.TabIndex = 19;
            button4.Text = "Proj.-Wahl";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(10, 10);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(94, 15);
            label10.TabIndex = 19;
            label10.Text = "ProjID(Vorläufig)";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(234, 28);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(project_TimeControl1);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Size = new System.Drawing.Size(774, 516);
            splitContainer1.SplitterDistance = 365;
            splitContainer1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(fileNameLabel);
            groupBox2.Controls.Add(fileTypeLabel);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tb_filepath);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new System.Drawing.Point(2, 2);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(361, 481);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new System.Drawing.Point(5, 464);
            fileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new System.Drawing.Size(25, 15);
            fileNameLabel.TabIndex = 15;
            fileNameLabel.Text = "Dir:";
            // 
            // fileTypeLabel
            // 
            fileTypeLabel.AutoSize = true;
            fileTypeLabel.Location = new System.Drawing.Point(100, 464);
            fileTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fileTypeLabel.Name = "fileTypeLabel";
            fileTypeLabel.Size = new System.Drawing.Size(25, 15);
            fileTypeLabel.TabIndex = 14;
            fileTypeLabel.Text = "Dir:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(5, 264);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(25, 15);
            label11.TabIndex = 13;
            label11.Text = "Dir:";
            // 
            // tb_filepath
            // 
            tb_filepath.Enabled = false;
            tb_filepath.Location = new System.Drawing.Point(55, 261);
            tb_filepath.Margin = new System.Windows.Forms.Padding(2);
            tb_filepath.Name = "tb_filepath";
            tb_filepath.Size = new System.Drawing.Size(283, 23);
            tb_filepath.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(6, 290);
            listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(331, 146);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.SmallIcon;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // project_TimeControl1
            // 
            project_TimeControl1.Location = new System.Drawing.Point(3, 2);
            project_TimeControl1.Name = "project_TimeControl1";
            project_TimeControl1.Size = new System.Drawing.Size(399, 511);
            project_TimeControl1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(614, 21);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(89, 15);
            label9.TabIndex = 18;
            label9.Text = "Lehrstuhl/Chair";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new System.Drawing.Point(4, 27);
            tabPage2.Margin = new System.Windows.Forms.Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(2);
            tabPage2.Size = new System.Drawing.Size(1029, 557);
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
            tableLayoutPanel1.Size = new System.Drawing.Size(191, 78);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button3.Location = new System.Drawing.Point(8, 47);
            button3.Margin = new System.Windows.Forms.Padding(8);
            button3.MaximumSize = new System.Drawing.Size(0, 80);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(79, 23);
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
            tabPage3.Size = new System.Drawing.Size(1029, 557);
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
            settingsControl1.Size = new System.Drawing.Size(1008, 446);
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
            // project_MainControl1
            // 
            project_MainControl1.Location = new System.Drawing.Point(0, 28);
            project_MainControl1.MinimumSize = new System.Drawing.Size(150, 440);
            project_MainControl1.Name = "project_MainControl1";
            project_MainControl1.Size = new System.Drawing.Size(219, 523);
            project_MainControl1.TabIndex = 20;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1037, 588);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(231, 107);
            Name = "Main";
            Text = "Form1";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_DB_File;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_SetDB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private SettingsControl settingsControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Project_TimeControl project_TimeControl1;
        private Tab_Project.Project_MainControl project_MainControl1;
    }
}

