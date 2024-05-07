namespace mySQL_Projektverwaltung { 
    partial class SettingsControl_Folder
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
            bt_folder = new System.Windows.Forms.Button();
            tb_folder = new System.Windows.Forms.TextBox();
            tb_regex = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bt_save = new System.Windows.Forms.Button();
            lb_regex = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_folder
            // 
            bt_folder.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bt_folder.Location = new System.Drawing.Point(3, 64);
            bt_folder.Name = "bt_folder";
            bt_folder.Size = new System.Drawing.Size(75, 23);
            bt_folder.TabIndex = 0;
            bt_folder.Text = "Folder";
            bt_folder.UseVisualStyleBackColor = true;
            bt_folder.Click += bt_folder_Click;
            // 
            // tb_folder
            // 
            tb_folder.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_folder, 3);
            tb_folder.Enabled = false;
            tb_folder.Location = new System.Drawing.Point(84, 64);
            tb_folder.Name = "tb_folder";
            tb_folder.Size = new System.Drawing.Size(536, 23);
            tb_folder.TabIndex = 1;
            // 
            // tb_regex
            // 
            tb_regex.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_regex, 3);
            tb_regex.Location = new System.Drawing.Point(84, 168);
            tb_regex.Name = "tb_regex";
            tb_regex.Size = new System.Drawing.Size(536, 23);
            tb_regex.TabIndex = 2;
            tb_regex.TextChanged += tb_regex_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(tb_regex, 1, 4);
            tableLayoutPanel1.Controls.Add(tb_folder, 1, 2);
            tableLayoutPanel1.Controls.Add(bt_folder, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(bt_save, 3, 6);
            tableLayoutPanel1.Controls.Add(lb_regex, 1, 5);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(623, 284);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 4);
            label2.Location = new System.Drawing.Point(3, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(617, 75);
            label2.TabIndex = 5;
            label2.Text = "Name d. Projektordner. Beispiel: \r\n- \"Projekt [n]\" für \"Projekt 3\"\r\n- \"Projekt[n3]\" für \"Projekt003\"\r\n- \"Projekt\" für \"Projekt3\"\r\n- evtl. Jahreskennung\r\n";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(3, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(617, 21);
            label1.TabIndex = 4;
            label1.Text = "Projekt-Überordner";
            // 
            // bt_save
            // 
            bt_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_save.Location = new System.Drawing.Point(545, 258);
            bt_save.Name = "bt_save";
            bt_save.Size = new System.Drawing.Size(75, 23);
            bt_save.TabIndex = 6;
            bt_save.Text = "Speichern";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // lb_regex
            // 
            lb_regex.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lb_regex, 3);
            lb_regex.Location = new System.Drawing.Point(84, 194);
            lb_regex.Name = "lb_regex";
            lb_regex.Size = new System.Drawing.Size(51, 15);
            lb_regex.TabIndex = 7;
            lb_regex.Text = "lb_regex";
            // 
            // SettingsControl_Folder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "SettingsControl_Folder";
            Size = new System.Drawing.Size(623, 284);
            Load += SettingsControl_Folder_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bt_folder;
        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_regex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lb_regex;
    }
}
