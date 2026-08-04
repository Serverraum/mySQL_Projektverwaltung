namespace mySQL_Projektverwaltung.Tab_LS_AG
{
    partial class LS_Control
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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            dtp_datecreated = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            dtp_dateremoved = new System.Windows.Forms.DateTimePicker();
            cb_removed_null = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            tb_LS = new System.Windows.Forms.TextBox();
            bt_saveLS = new System.Windows.Forms.Button();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            aG_Control1 = new AG_Control();
            tabPage4 = new System.Windows.Forms.TabPage();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(dtp_datecreated);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(dtp_dateremoved);
            flowLayoutPanel1.Controls.Add(cb_removed_null);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(tb_LS);
            flowLayoutPanel1.Controls.Add(bt_saveLS);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(213, 650);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 15);
            label6.TabIndex = 7;
            label6.Text = "Ernannt";
            // 
            // dtp_datecreated
            // 
            dtp_datecreated.Location = new System.Drawing.Point(3, 18);
            dtp_datecreated.Name = "dtp_datecreated";
            dtp_datecreated.Size = new System.Drawing.Size(200, 23);
            dtp_datecreated.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 44);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 15);
            label5.TabIndex = 6;
            label5.Text = "Entfernt";
            // 
            // dtp_dateremoved
            // 
            dtp_dateremoved.Location = new System.Drawing.Point(3, 62);
            dtp_dateremoved.Name = "dtp_dateremoved";
            dtp_dateremoved.Size = new System.Drawing.Size(200, 23);
            dtp_dateremoved.TabIndex = 3;
            // 
            // cb_removed_null
            // 
            cb_removed_null.AutoSize = true;
            cb_removed_null.Location = new System.Drawing.Point(3, 91);
            cb_removed_null.Name = "cb_removed_null";
            cb_removed_null.Size = new System.Drawing.Size(174, 19);
            cb_removed_null.TabIndex = 14;
            cb_removed_null.Text = "Noch aktiv / kein Enddatum";
            cb_removed_null.UseVisualStyleBackColor = true;
            cb_removed_null.CheckedChanged += cb_removed_null_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // tb_LS
            // 
            tb_LS.Location = new System.Drawing.Point(3, 131);
            tb_LS.MaxLength = 49;
            tb_LS.Name = "tb_LS";
            tb_LS.Size = new System.Drawing.Size(200, 23);
            tb_LS.TabIndex = 4;
            // 
            // bt_saveLS
            // 
            bt_saveLS.AutoSize = true;
            bt_saveLS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bt_saveLS.Location = new System.Drawing.Point(3, 160);
            bt_saveLS.Name = "bt_saveLS";
            bt_saveLS.Size = new System.Drawing.Size(120, 25);
            bt_saveLS.TabIndex = 8;
            bt_saveLS.Text = "Lehrstuhl speichern";
            bt_saveLS.UseVisualStyleBackColor = true;
            bt_saveLS.Click += bt_saveLS_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 191);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new System.Drawing.Point(219, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(873, 650);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arbeitsgruppe";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(3, 19);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(867, 628);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(aG_Control1);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(859, 600);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // aG_Control1
            // 
            aG_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            aG_Control1.Location = new System.Drawing.Point(3, 3);
            aG_Control1.Name = "aG_Control1";
            aG_Control1.Size = new System.Drawing.Size(853, 594);
            aG_Control1.TabIndex = 9;
            aG_Control1.Tag = "1";
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(192, 72);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // LS_Control
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox2);
            Name = "LS_Control";
            Size = new System.Drawing.Size(1092, 650);
            Load += LS_Control_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_datecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_dateremoved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_LS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bt_saveLS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private AG_Control aG_Control1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cb_removed_null;
    }
}
