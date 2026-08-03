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
            dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            bt_saveAG = new System.Windows.Forms.Button();
            bt_deleteAG = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(dateTimePicker3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(dateTimePicker4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Controls.Add(bt_saveAG);
            flowLayoutPanel1.Controls.Add(bt_deleteAG);
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
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new System.Drawing.Point(3, 18);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new System.Drawing.Size(200, 23);
            dateTimePicker3.TabIndex = 0;
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
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new System.Drawing.Point(3, 62);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new System.Drawing.Size(200, 23);
            dateTimePicker4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(3, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // bt_saveAG
            // 
            bt_saveAG.AutoSize = true;
            bt_saveAG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bt_saveAG.Location = new System.Drawing.Point(3, 135);
            bt_saveAG.Name = "bt_saveAG";
            bt_saveAG.Size = new System.Drawing.Size(146, 25);
            bt_saveAG.TabIndex = 10;
            bt_saveAG.Text = "Speichere Arbeitsgruppe";
            bt_saveAG.UseVisualStyleBackColor = true;
            // 
            // bt_deleteAG
            // 
            bt_deleteAG.AutoSize = true;
            bt_deleteAG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bt_deleteAG.Location = new System.Drawing.Point(3, 166);
            bt_deleteAG.Name = "bt_deleteAG";
            bt_deleteAG.Size = new System.Drawing.Size(132, 25);
            bt_deleteAG.TabIndex = 11;
            bt_deleteAG.Text = "Lösche Arbeitsgruppe";
            bt_deleteAG.UseVisualStyleBackColor = true;
            // 
            // AG_Control
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "AG_Control";
            Size = new System.Drawing.Size(765, 670);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bt_saveAG;
        private System.Windows.Forms.Button bt_deleteAG;
    }
}
