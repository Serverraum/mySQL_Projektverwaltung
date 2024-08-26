namespace mySQL_Projektverwaltung.Tab_Übersicht
{
    partial class Uebersicht_AG
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            AG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stunden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Prozent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LS_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { AG, Stunden, Prozent });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(121, 41);
            dataGridView1.TabIndex = 16;
            // 
            // AG
            // 
            AG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            AG.HeaderText = "AG";
            AG.Name = "AG";
            AG.ReadOnly = true;
            // 
            // Stunden
            // 
            Stunden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            Stunden.HeaderText = "h";
            Stunden.Name = "Stunden";
            Stunden.ReadOnly = true;
            Stunden.Width = 39;
            // 
            // Prozent
            // 
            Prozent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            Prozent.HeaderText = "%";
            Prozent.Name = "Prozent";
            Prozent.ReadOnly = true;
            Prozent.Width = 42;
            // 
            // LS_name
            // 
            LS_name.AutoSize = true;
            LS_name.Dock = System.Windows.Forms.DockStyle.Top;
            LS_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LS_name.Location = new System.Drawing.Point(0, 0);
            LS_name.Name = "LS_name";
            LS_name.Size = new System.Drawing.Size(50, 21);
            LS_name.TabIndex = 17;
            LS_name.Text = "Chair";
            // 
            // Uebersicht_AG
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dataGridView1);
            Controls.Add(LS_name);
            MinimumSize = new System.Drawing.Size(120, 60);
            Name = "Uebersicht_AG";
            Size = new System.Drawing.Size(121, 62);
            Load += Uebersicht_AG_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stunden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prozent;
        private System.Windows.Forms.Label LS_name;
    }
}
