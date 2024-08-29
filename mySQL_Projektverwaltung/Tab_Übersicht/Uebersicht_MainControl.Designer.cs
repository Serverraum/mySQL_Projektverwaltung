namespace mySQL_Projektverwaltung.Tab_Übersicht
{
    partial class Uebersicht_MainControl
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
            year_select_UD = new System.Windows.Forms.NumericUpDown();
            button2 = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            uebersicht_ag1 = new Uebersicht_AG();
            tabPage2 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)year_select_UD).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // year_select_UD
            // 
            year_select_UD.Location = new System.Drawing.Point(18, 34);
            year_select_UD.Maximum = new decimal(new int[] { 2022, 0, 0, 0 });
            year_select_UD.Minimum = new decimal(new int[] { 2022, 0, 0, 0 });
            year_select_UD.Name = "year_select_UD";
            year_select_UD.Size = new System.Drawing.Size(127, 23);
            year_select_UD.TabIndex = 12;
            year_select_UD.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(18, 68);
            button2.Margin = new System.Windows.Forms.Padding(8);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(127, 42);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(156, 16);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(453, 584);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uebersicht_ag1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(445, 556);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uebersicht_ag1
            // 
            uebersicht_ag1.AutoSize = true;
            uebersicht_ag1.Location = new System.Drawing.Point(6, 6);
            uebersicht_ag1.MinimumSize = new System.Drawing.Size(120, 60);
            uebersicht_ag1.Name = "uebersicht_ag1";
            uebersicht_ag1.Size = new System.Drawing.Size(164, 138);
            uebersicht_ag1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(445, 556);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // Uebersicht_MainControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(year_select_UD);
            Controls.Add(button2);
            Name = "Uebersicht_MainControl";
            Size = new System.Drawing.Size(631, 620);
            ((System.ComponentModel.ISupportInitialize)year_select_UD).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown year_select_UD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private Uebersicht_AG uebersicht_ag1;
    }
}
