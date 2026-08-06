namespace mySQL_Projektverwaltung.Tab_LS_AG
{
    partial class AG_Control
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
            label3 = new System.Windows.Forms.Label();
            dtp_datecreated = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            dtp_dateremoved = new System.Windows.Forms.DateTimePicker();
            cb_removed_null = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            tb_AG = new System.Windows.Forms.TextBox();
            cb_extra_bill = new System.Windows.Forms.CheckBox();
            bt_saveAG = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(dtp_datecreated);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(dtp_dateremoved);
            flowLayoutPanel1.Controls.Add(cb_removed_null);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(tb_AG);
            flowLayoutPanel1.Controls.Add(cb_extra_bill);
            flowLayoutPanel1.Controls.Add(bt_saveAG);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(765, 670);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Ernannt";
            // 
            // dtp_datecreated
            // 
            dtp_datecreated.Location = new System.Drawing.Point(3, 18);
            dtp_datecreated.Name = "dtp_datecreated";
            dtp_datecreated.Size = new System.Drawing.Size(200, 23);
            dtp_datecreated.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Entfernt";
            // 
            // dtp_dateremoved
            // 
            dtp_dateremoved.Location = new System.Drawing.Point(3, 62);
            dtp_dateremoved.Name = "dtp_dateremoved";
            dtp_dateremoved.Size = new System.Drawing.Size(200, 23);
            dtp_dateremoved.TabIndex = 1;
            // 
            // cb_removed_null
            // 
            cb_removed_null.AutoSize = true;
            cb_removed_null.Location = new System.Drawing.Point(3, 91);
            cb_removed_null.Name = "cb_removed_null";
            cb_removed_null.Size = new System.Drawing.Size(174, 19);
            cb_removed_null.TabIndex = 13;
            cb_removed_null.Text = "Noch aktiv / kein Enddatum";
            cb_removed_null.UseVisualStyleBackColor = true;
            cb_removed_null.CheckedChanged += cb_removed_null_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 113);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // tb_AG
            // 
            tb_AG.Location = new System.Drawing.Point(3, 131);
            tb_AG.MaxLength = 49;
            tb_AG.Name = "tb_AG";
            tb_AG.Size = new System.Drawing.Size(200, 23);
            tb_AG.TabIndex = 2;
            // 
            // cb_extra_bill
            // 
            cb_extra_bill.AutoSize = true;
            cb_extra_bill.Location = new System.Drawing.Point(3, 160);
            cb_extra_bill.Name = "cb_extra_bill";
            cb_extra_bill.Size = new System.Drawing.Size(142, 19);
            cb_extra_bill.TabIndex = 12;
            cb_extra_bill.Text = "Zusätzliche Rechnung";
            cb_extra_bill.UseVisualStyleBackColor = true;
            // 
            // bt_saveAG
            // 
            bt_saveAG.AutoSize = true;
            bt_saveAG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bt_saveAG.Location = new System.Drawing.Point(3, 185);
            bt_saveAG.Name = "bt_saveAG";
            bt_saveAG.Size = new System.Drawing.Size(146, 25);
            bt_saveAG.TabIndex = 10;
            bt_saveAG.Text = "Arbeitsgruppe speichern";
            bt_saveAG.UseVisualStyleBackColor = true;
            bt_saveAG.Click += bt_saveAG_Click;
            // 
            // AG_Control
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "AG_Control";
            Size = new System.Drawing.Size(765, 670);
            Load += AG_Control_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_datecreated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dateremoved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AG;
        private System.Windows.Forms.Button bt_saveAG;
        private System.Windows.Forms.CheckBox cb_extra_bill;
        private System.Windows.Forms.CheckBox cb_removed_null;
    }
}
