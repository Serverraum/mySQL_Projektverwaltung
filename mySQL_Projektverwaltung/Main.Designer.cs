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
            button1 = new System.Windows.Forms.Button();
            tb_name = new System.Windows.Forms.TextBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            button2 = new System.Windows.Forms.Button();
            cb_LS = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            mtb_date = new System.Windows.Forms.MaskedTextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            button4 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            editProj = new System.Windows.Forms.CheckBox();
            bt_proj_save = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            tb_shortdesc = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tb_email = new System.Windows.Forms.TextBox();
            tb_tel = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cb_AG = new System.Windows.Forms.ComboBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBox2 = new System.Windows.Forms.GroupBox();
            fileNameLabel = new System.Windows.Forms.Label();
            fileTypeLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tb_filepath = new System.Windows.Forms.TextBox();
            listView1 = new System.Windows.Forms.ListView();
            project_TimeControl1 = new Project_TimeControl();
            label9 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button3 = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            settingsControl1 = new SettingsControl();
            tb_DB_File = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            Button_SetDB = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(2, 2);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(65, 22);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_name
            // 
            tb_name.Enabled = false;
            tb_name.Location = new System.Drawing.Point(56, 175);
            tb_name.Margin = new System.Windows.Forms.Padding(2);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(153, 23);
            tb_name.TabIndex = 1;
            tb_name.TextChanged += textBox1_TextChanged;
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
            button2.Location = new System.Drawing.Point(2, 2);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(65, 22);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // cb_LS
            // 
            cb_LS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cb_LS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_LS.Enabled = false;
            cb_LS.Location = new System.Drawing.Point(21, 78);
            cb_LS.Margin = new System.Windows.Forms.Padding(2);
            cb_LS.Name = "cb_LS";
            cb_LS.Size = new System.Drawing.Size(107, 23);
            cb_LS.TabIndex = 4;
            cb_LS.SelectionChangeCommitted += cb_LS_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 61);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Lehrstuhl/Chair";
            label1.Click += Main_Load;
            label1.MouseCaptureChanged += label1_MouseCaptureChanged;
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
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // mtb_date
            // 
            mtb_date.Enabled = false;
            mtb_date.Location = new System.Drawing.Point(121, 297);
            mtb_date.Margin = new System.Windows.Forms.Padding(2);
            mtb_date.Mask = "00/00/0000";
            mtb_date.Name = "mtb_date";
            mtb_date.Size = new System.Drawing.Size(88, 23);
            mtb_date.TabIndex = 7;
            mtb_date.ValidatingType = typeof(System.DateTime);
            mtb_date.TextChanged += mtb_date_TextChanged;
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
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(groupBox1);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(editProj);
            groupBox1.Controls.Add(bt_proj_save);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_shortdesc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_tel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cb_AG);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_LS);
            groupBox1.Controls.Add(tb_name);
            groupBox1.Controls.Add(mtb_date);
            groupBox1.Location = new System.Drawing.Point(8, 28);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(222, 383);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // editProj
            // 
            editProj.Appearance = System.Windows.Forms.Appearance.Button;
            editProj.BackgroundImage = Properties.Resources.pen3;
            editProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            editProj.Location = new System.Drawing.Point(155, 14);
            editProj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            editProj.Name = "editProj";
            editProj.Size = new System.Drawing.Size(28, 28);
            editProj.TabIndex = 22;
            editProj.UseVisualStyleBackColor = true;
            editProj.CheckedChanged += editProj_CheckedChanged;
            // 
            // bt_proj_save
            // 
            bt_proj_save.BackgroundImage = Properties.Resources.save;
            bt_proj_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_proj_save.Enabled = false;
            bt_proj_save.FlatAppearance.BorderSize = 0;
            bt_proj_save.ImageKey = "(Keine)";
            bt_proj_save.Location = new System.Drawing.Point(189, 14);
            bt_proj_save.Margin = new System.Windows.Forms.Padding(2);
            bt_proj_save.Name = "bt_proj_save";
            bt_proj_save.Size = new System.Drawing.Size(28, 28);
            bt_proj_save.TabIndex = 20;
            bt_proj_save.UseVisualStyleBackColor = true;
            bt_proj_save.MouseClick += bt_proj_save_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(2, 337);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(198, 15);
            label7.TabIndex = 17;
            label7.Text = "Kurzbeschreibung/Short Description";
            // 
            // tb_shortdesc
            // 
            tb_shortdesc.Enabled = false;
            tb_shortdesc.Location = new System.Drawing.Point(5, 354);
            tb_shortdesc.Margin = new System.Windows.Forms.Padding(2);
            tb_shortdesc.Name = "tb_shortdesc";
            tb_shortdesc.Size = new System.Drawing.Size(205, 23);
            tb_shortdesc.TabIndex = 16;
            tb_shortdesc.TextChanged += tb_shortdesc_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(5, 300);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 15;
            label6.Text = "Datum/Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 248);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "eMail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 209);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 15);
            label4.TabIndex = 13;
            label4.Text = "Tel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 179);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // tb_email
            // 
            tb_email.Enabled = false;
            tb_email.Location = new System.Drawing.Point(56, 245);
            tb_email.Margin = new System.Windows.Forms.Padding(2);
            tb_email.Name = "tb_email";
            tb_email.Size = new System.Drawing.Size(153, 23);
            tb_email.TabIndex = 11;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // tb_tel
            // 
            tb_tel.Enabled = false;
            tb_tel.Location = new System.Drawing.Point(56, 209);
            tb_tel.Margin = new System.Windows.Forms.Padding(2);
            tb_tel.Name = "tb_tel";
            tb_tel.Size = new System.Drawing.Size(153, 23);
            tb_tel.TabIndex = 10;
            tb_tel.TextChanged += tb_tel_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 105);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 15);
            label2.TabIndex = 9;
            label2.Text = "Arbeitsgruppe/Group\r\n";
            // 
            // cb_AG
            // 
            cb_AG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cb_AG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_AG.Enabled = false;
            cb_AG.FormattingEnabled = true;
            cb_AG.Location = new System.Drawing.Point(21, 122);
            cb_AG.Margin = new System.Windows.Forms.Padding(2);
            cb_AG.Name = "cb_AG";
            cb_AG.Size = new System.Drawing.Size(107, 23);
            cb_AG.TabIndex = 8;
            cb_AG.SelectionChangeCommitted += cb_AG_SelectionChangeCommitted;
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
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(button1);
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
            groupBox2.Size = new System.Drawing.Size(343, 481);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            groupBox2.Enter += groupBox2_Enter;
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
            project_TimeControl1.Location = new System.Drawing.Point(3, 112);
            project_TimeControl1.Name = "project_TimeControl1";
            project_TimeControl1.Size = new System.Drawing.Size(399, 401);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(2, 28);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(400, 79);
            dataGridView1.TabIndex = 7;
            dataGridView1.VirtualMode = true;
            dataGridView1.CellClick += NewRow_DGVprojHours;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += DGV_Update;
            dataGridView1.UserDeletingRow += DGVprojHours_UserDeletingRow;
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(120, 98);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(147, 93);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(2, 48);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(65, 22);
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_LS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox mtb_date;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_AG;
        private System.Windows.Forms.TextBox tb_shortdesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_DB_File;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_SetDB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_proj_save;
        private System.Windows.Forms.CheckBox editProj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private SettingsControl settingsControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Project_TimeControl project_TimeControl1;
    }
}

