namespace mySQL_Projektverwaltung.Tab_Project
{
    partial class Project_DetailsControl
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
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(426, 21);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Details:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(426, 29);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "ClearEffekts(N.F.)";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Location = new System.Drawing.Point(5, 55);
            richTextBox1.Margin = new System.Windows.Forms.Padding(20);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(416, 402);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "test";
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // Project_DetailsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Project_DetailsControl";
            Size = new System.Drawing.Size(426, 465);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
