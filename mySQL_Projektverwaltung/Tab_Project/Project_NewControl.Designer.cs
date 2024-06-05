namespace mySQL_Projektverwaltung.Tab_Project
{
    partial class Project_NewControl
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
            bt_new = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // bt_new
            // 
            bt_new.AutoSize = true;
            bt_new.Dock = System.Windows.Forms.DockStyle.Fill;
            bt_new.Location = new System.Drawing.Point(0, 0);
            bt_new.Margin = new System.Windows.Forms.Padding(0);
            bt_new.Name = "bt_new";
            bt_new.Size = new System.Drawing.Size(90, 25);
            bt_new.TabIndex = 0;
            bt_new.Text = "Neues Projekt";
            bt_new.UseVisualStyleBackColor = true;
            bt_new.Click += bt_new_Click;
            // 
            // Project_NewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(bt_new);
            Name = "Project_NewControl";
            Size = new System.Drawing.Size(90, 25);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bt_new;
    }
}
