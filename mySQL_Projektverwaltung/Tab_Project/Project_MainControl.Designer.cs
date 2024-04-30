namespace mySQL_Projektverwaltung.Tab_Project
{
    partial class Project_MainControl
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
            editProj = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            tb_shortdesc = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cb_AG = new System.Windows.Forms.ComboBox();
            cb_LS = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            mtb_date = new System.Windows.Forms.MaskedTextBox();
            tb_email = new System.Windows.Forms.TextBox();
            tb_tel = new System.Windows.Forms.TextBox();
            tb_name = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bt_proj_save = new System.Windows.Forms.Button();
            bt_completed = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // editProj
            // 
            editProj.Appearance = System.Windows.Forms.Appearance.Button;
            editProj.BackgroundImage = Properties.Resources.pen3;
            editProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            editProj.Location = new System.Drawing.Point(231, 2);
            editProj.Margin = new System.Windows.Forms.Padding(2);
            editProj.Name = "editProj";
            editProj.Size = new System.Drawing.Size(28, 26);
            editProj.TabIndex = 22;
            editProj.UseVisualStyleBackColor = true;
            editProj.CheckedChanged += editProj_CheckedChanged;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label7, 5);
            label7.Location = new System.Drawing.Point(2, 337);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(257, 15);
            label7.TabIndex = 17;
            label7.Text = "Kurzbeschreibung/Short Description";
            // 
            // tb_shortdesc
            // 
            tb_shortdesc.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_shortdesc, 4);
            tb_shortdesc.Enabled = false;
            tb_shortdesc.Location = new System.Drawing.Point(12, 363);
            tb_shortdesc.Margin = new System.Windows.Forms.Padding(2);
            tb_shortdesc.Name = "tb_shortdesc";
            tb_shortdesc.Size = new System.Drawing.Size(247, 23);
            tb_shortdesc.TabIndex = 16;
            tb_shortdesc.TextChanged += tb_shortdesc_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 5);
            label2.Location = new System.Drawing.Point(2, 97);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 15);
            label2.TabIndex = 9;
            label2.Text = "Arbeitsgruppe/Group\r\n";
            // 
            // cb_AG
            // 
            cb_AG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb_AG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            tableLayoutPanel1.SetColumnSpan(cb_AG, 4);
            cb_AG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_AG.Enabled = false;
            cb_AG.FormattingEnabled = true;
            cb_AG.Location = new System.Drawing.Point(12, 123);
            cb_AG.Margin = new System.Windows.Forms.Padding(2);
            cb_AG.Name = "cb_AG";
            cb_AG.Size = new System.Drawing.Size(247, 23);
            cb_AG.TabIndex = 8;
            cb_AG.SelectionChangeCommitted += cb_AG_SelectionChangeCommitted;
            // 
            // cb_LS
            // 
            cb_LS.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb_LS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            tableLayoutPanel1.SetColumnSpan(cb_LS, 4);
            cb_LS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_LS.Enabled = false;
            cb_LS.Location = new System.Drawing.Point(12, 63);
            cb_LS.Margin = new System.Windows.Forms.Padding(2);
            cb_LS.Name = "cb_LS";
            cb_LS.Size = new System.Drawing.Size(247, 23);
            cb_LS.TabIndex = 4;
            cb_LS.SelectionChangeCommitted += cb_LS_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(275, 523);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(mtb_date, 2, 9);
            tableLayoutPanel1.Controls.Add(tb_email, 2, 7);
            tableLayoutPanel1.Controls.Add(tb_tel, 2, 6);
            tableLayoutPanel1.Controls.Add(tb_shortdesc, 1, 12);
            tableLayoutPanel1.Controls.Add(tb_name, 2, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 11);
            tableLayoutPanel1.Controls.Add(cb_LS, 1, 2);
            tableLayoutPanel1.Controls.Add(cb_AG, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 9);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(editProj, 4, 0);
            tableLayoutPanel1.Controls.Add(bt_proj_save, 3, 0);
            tableLayoutPanel1.Controls.Add(bt_completed, 1, 13);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(2, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(271, 503);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // mtb_date
            // 
            mtb_date.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(mtb_date, 3);
            mtb_date.Enabled = false;
            mtb_date.Location = new System.Drawing.Point(81, 273);
            mtb_date.Margin = new System.Windows.Forms.Padding(2);
            mtb_date.Mask = "00/00/0000";
            mtb_date.Name = "mtb_date";
            mtb_date.Size = new System.Drawing.Size(178, 23);
            mtb_date.TabIndex = 7;
            mtb_date.ValidatingType = typeof(System.DateTime);
            mtb_date.TextChanged += mtb_date_TextChanged;
            // 
            // tb_email
            // 
            tableLayoutPanel1.SetColumnSpan(tb_email, 3);
            tb_email.Enabled = false;
            tb_email.Location = new System.Drawing.Point(81, 212);
            tb_email.Margin = new System.Windows.Forms.Padding(2);
            tb_email.Name = "tb_email";
            tb_email.Size = new System.Drawing.Size(139, 23);
            tb_email.TabIndex = 11;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // tb_tel
            // 
            tableLayoutPanel1.SetColumnSpan(tb_tel, 3);
            tb_tel.Enabled = false;
            tb_tel.Location = new System.Drawing.Point(81, 182);
            tb_tel.Margin = new System.Windows.Forms.Padding(2);
            tb_tel.Name = "tb_tel";
            tb_tel.Size = new System.Drawing.Size(139, 23);
            tb_tel.TabIndex = 10;
            tb_tel.TextChanged += tb_tel_TextChanged;
            // 
            // tb_name
            // 
            tableLayoutPanel1.SetColumnSpan(tb_name, 3);
            tb_name.Enabled = false;
            tb_name.Location = new System.Drawing.Point(81, 152);
            tb_name.Margin = new System.Windows.Forms.Padding(2);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(139, 23);
            tb_name.TabIndex = 1;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label6, 2);
            label6.Location = new System.Drawing.Point(2, 277);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 15;
            label6.Text = "Datum/Date:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Location = new System.Drawing.Point(35, 157);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Location = new System.Drawing.Point(38, 217);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "eMail:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Location = new System.Drawing.Point(53, 187);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 15);
            label4.TabIndex = 13;
            label4.Text = "Tel:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 5);
            label1.Location = new System.Drawing.Point(2, 37);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Lehrstuhl/Chair";
            // 
            // bt_proj_save
            // 
            bt_proj_save.BackgroundImage = Properties.Resources.save;
            bt_proj_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_proj_save.Enabled = false;
            bt_proj_save.FlatAppearance.BorderSize = 0;
            bt_proj_save.ImageKey = "(Keine)";
            bt_proj_save.Location = new System.Drawing.Point(199, 2);
            bt_proj_save.Margin = new System.Windows.Forms.Padding(2);
            bt_proj_save.Name = "bt_proj_save";
            bt_proj_save.Size = new System.Drawing.Size(28, 26);
            bt_proj_save.TabIndex = 20;
            bt_proj_save.UseVisualStyleBackColor = true;
            bt_proj_save.Click += bt_proj_save_Click;
            // 
            // bt_completed
            // 
            bt_completed.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bt_completed.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(bt_completed, 4);
            bt_completed.Enabled = false;
            bt_completed.Location = new System.Drawing.Point(13, 393);
            bt_completed.Name = "bt_completed";
            bt_completed.Size = new System.Drawing.Size(245, 24);
            bt_completed.TabIndex = 23;
            bt_completed.Text = "Project Completed?";
            bt_completed.UseVisualStyleBackColor = true;
            bt_completed.Click += bt_completed_Click;
            // 
            // Project_MainControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupBox1);
            MinimumSize = new System.Drawing.Size(150, 440);
            Name = "Project_MainControl";
            Size = new System.Drawing.Size(275, 523);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckBox editProj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_shortdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_AG;
        private System.Windows.Forms.ComboBox cb_LS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox mtb_date;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_proj_save;
        private System.Windows.Forms.Button bt_completed;
    }
}
