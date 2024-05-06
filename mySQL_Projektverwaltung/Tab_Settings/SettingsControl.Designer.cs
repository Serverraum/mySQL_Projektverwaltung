namespace mySQL_Projektverwaltung
{
    partial class SettingsControl
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
            bt_Save = new System.Windows.Forms.Button();
            tb_DB_File = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            Button_SetDB = new System.Windows.Forms.Button();
            rb_SQLite = new System.Windows.Forms.RadioButton();
            rb_mySQL = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            tb_server = new System.Windows.Forms.TextBox();
            tb_uid = new System.Windows.Forms.TextBox();
            tb_database = new System.Windows.Forms.TextBox();
            tb_pwd = new System.Windows.Forms.TextBox();
            hint_server = new System.Windows.Forms.Label();
            hint_database = new System.Windows.Forms.Label();
            hint_UID = new System.Windows.Forms.Label();
            hint_pwd = new System.Windows.Forms.Label();
            bt_showPWD = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // bt_Save
            // 
            bt_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_Save.Location = new System.Drawing.Point(147, 269);
            bt_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new System.Drawing.Size(88, 27);
            bt_Save.TabIndex = 0;
            bt_Save.Text = "Save";
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // tb_DB_File
            // 
            tb_DB_File.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_DB_File.Enabled = false;
            tb_DB_File.ImeMode = System.Windows.Forms.ImeMode.On;
            tb_DB_File.Location = new System.Drawing.Point(111, 69);
            tb_DB_File.Margin = new System.Windows.Forms.Padding(2);
            tb_DB_File.Name = "tb_DB_File";
            tb_DB_File.Size = new System.Drawing.Size(123, 23);
            tb_DB_File.TabIndex = 5;
            tb_DB_File.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new System.Drawing.Point(112, 52);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(114, 15);
            label8.TabIndex = 4;
            label8.Text = "Pfad der Datenbank:";
            // 
            // Button_SetDB
            // 
            Button_SetDB.Enabled = false;
            Button_SetDB.Location = new System.Drawing.Point(51, 70);
            Button_SetDB.Margin = new System.Windows.Forms.Padding(2);
            Button_SetDB.Name = "Button_SetDB";
            Button_SetDB.Size = new System.Drawing.Size(55, 22);
            Button_SetDB.TabIndex = 3;
            Button_SetDB.Text = "DB";
            Button_SetDB.UseVisualStyleBackColor = true;
            Button_SetDB.Click += Button_SetDB_Click;
            // 
            // rb_SQLite
            // 
            rb_SQLite.AutoSize = true;
            rb_SQLite.Location = new System.Drawing.Point(22, 15);
            rb_SQLite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_SQLite.Name = "rb_SQLite";
            rb_SQLite.Size = new System.Drawing.Size(59, 19);
            rb_SQLite.TabIndex = 6;
            rb_SQLite.TabStop = true;
            rb_SQLite.Text = "SQLite";
            rb_SQLite.UseVisualStyleBackColor = true;
            rb_SQLite.CheckedChanged += rb_SQLite_CheckedChanged;
            // 
            // rb_mySQL
            // 
            rb_mySQL.AutoSize = true;
            rb_mySQL.Location = new System.Drawing.Point(22, 112);
            rb_mySQL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_mySQL.Name = "rb_mySQL";
            rb_mySQL.Size = new System.Drawing.Size(63, 19);
            rb_mySQL.TabIndex = 7;
            rb_mySQL.TabStop = true;
            rb_mySQL.Text = "mySQL";
            rb_mySQL.UseVisualStyleBackColor = true;
            rb_mySQL.CheckedChanged += rb_mySQL_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 0);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "Datenbanktyp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new System.Drawing.Point(58, 137);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Server:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new System.Drawing.Point(41, 172);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Database:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new System.Drawing.Point(72, 207);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 15);
            label4.TabIndex = 11;
            label4.Text = "UID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new System.Drawing.Point(41, 241);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Password:";
            // 
            // tb_server
            // 
            tb_server.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_server.BackColor = System.Drawing.SystemColors.Window;
            tb_server.Enabled = false;
            tb_server.ImeMode = System.Windows.Forms.ImeMode.On;
            tb_server.Location = new System.Drawing.Point(111, 134);
            tb_server.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            tb_server.Name = "tb_server";
            tb_server.Size = new System.Drawing.Size(123, 23);
            tb_server.TabIndex = 13;
            tb_server.TextChanged += tb_server_TextChanged;
            // 
            // tb_uid
            // 
            tb_uid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_uid.Enabled = false;
            tb_uid.ImeMode = System.Windows.Forms.ImeMode.On;
            tb_uid.Location = new System.Drawing.Point(111, 203);
            tb_uid.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            tb_uid.Name = "tb_uid";
            tb_uid.Size = new System.Drawing.Size(123, 23);
            tb_uid.TabIndex = 14;
            tb_uid.TabStop = false;
            tb_uid.TextChanged += tb_uid_TextChanged;
            // 
            // tb_database
            // 
            tb_database.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_database.Enabled = false;
            tb_database.ImeMode = System.Windows.Forms.ImeMode.On;
            tb_database.Location = new System.Drawing.Point(111, 168);
            tb_database.Margin = new System.Windows.Forms.Padding(2);
            tb_database.Name = "tb_database";
            tb_database.Size = new System.Drawing.Size(123, 23);
            tb_database.TabIndex = 15;
            tb_database.TabStop = false;
            tb_database.Text = "localhost";
            tb_database.TextChanged += tb_database_TextChanged;
            // 
            // tb_pwd
            // 
            tb_pwd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_pwd.Enabled = false;
            tb_pwd.ImeMode = System.Windows.Forms.ImeMode.On;
            tb_pwd.Location = new System.Drawing.Point(111, 238);
            tb_pwd.Margin = new System.Windows.Forms.Padding(2);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.Size = new System.Drawing.Size(86, 23);
            tb_pwd.TabIndex = 16;
            tb_pwd.TabStop = false;
            tb_pwd.UseSystemPasswordChar = true;
            tb_pwd.TextChanged += tb_pwd_TextChanged;
            // 
            // hint_server
            // 
            hint_server.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            hint_server.AutoSize = true;
            hint_server.BackColor = System.Drawing.SystemColors.Control;
            hint_server.Enabled = false;
            hint_server.ForeColor = System.Drawing.SystemColors.ControlDark;
            hint_server.Location = new System.Drawing.Point(112, 137);
            hint_server.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            hint_server.Name = "hint_server";
            hint_server.Size = new System.Drawing.Size(55, 15);
            hint_server.TabIndex = 17;
            hint_server.Text = "localhost";
            // 
            // hint_database
            // 
            hint_database.AutoSize = true;
            hint_database.BackColor = System.Drawing.SystemColors.Control;
            hint_database.Enabled = false;
            hint_database.ForeColor = System.Drawing.SystemColors.ControlDark;
            hint_database.Location = new System.Drawing.Point(112, 172);
            hint_database.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            hint_database.Name = "hint_database";
            hint_database.Size = new System.Drawing.Size(60, 15);
            hint_database.TabIndex = 18;
            hint_database.Tag = "";
            hint_database.Text = "database1";
            // 
            // hint_UID
            // 
            hint_UID.AutoSize = true;
            hint_UID.BackColor = System.Drawing.SystemColors.Control;
            hint_UID.Enabled = false;
            hint_UID.ForeColor = System.Drawing.SystemColors.ControlDark;
            hint_UID.Location = new System.Drawing.Point(112, 207);
            hint_UID.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            hint_UID.Name = "hint_UID";
            hint_UID.Size = new System.Drawing.Size(36, 15);
            hint_UID.TabIndex = 19;
            hint_UID.Text = "guest";
            // 
            // hint_pwd
            // 
            hint_pwd.AutoSize = true;
            hint_pwd.BackColor = System.Drawing.SystemColors.Control;
            hint_pwd.Enabled = false;
            hint_pwd.ForeColor = System.Drawing.SystemColors.ControlDark;
            hint_pwd.Location = new System.Drawing.Point(112, 241);
            hint_pwd.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            hint_pwd.Name = "hint_pwd";
            hint_pwd.Size = new System.Drawing.Size(42, 15);
            hint_pwd.TabIndex = 20;
            hint_pwd.Text = "●●●●●";
            // 
            // bt_showPWD
            // 
            bt_showPWD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bt_showPWD.Enabled = false;
            bt_showPWD.Location = new System.Drawing.Point(203, 238);
            bt_showPWD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bt_showPWD.Name = "bt_showPWD";
            bt_showPWD.Size = new System.Drawing.Size(31, 24);
            bt_showPWD.TabIndex = 21;
            bt_showPWD.Text = "E";
            bt_showPWD.UseVisualStyleBackColor = true;
            bt_showPWD.Click += bt_showPWD_Click;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(bt_showPWD);
            Controls.Add(hint_pwd);
            Controls.Add(hint_UID);
            Controls.Add(hint_database);
            Controls.Add(hint_server);
            Controls.Add(tb_pwd);
            Controls.Add(tb_database);
            Controls.Add(tb_uid);
            Controls.Add(tb_server);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rb_mySQL);
            Controls.Add(rb_SQLite);
            Controls.Add(tb_DB_File);
            Controls.Add(label8);
            Controls.Add(Button_SetDB);
            Controls.Add(bt_Save);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(260, 316);
            Name = "SettingsControl";
            Size = new System.Drawing.Size(260, 316);
            Load += SettingsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_DB_File;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_SetDB;
        private System.Windows.Forms.RadioButton rb_SQLite;
        private System.Windows.Forms.RadioButton rb_mySQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_uid;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label hint_server;
        private System.Windows.Forms.Label hint_database;
        private System.Windows.Forms.Label hint_UID;
        private System.Windows.Forms.Label hint_pwd;
        private System.Windows.Forms.Button bt_showPWD;
    }
}
