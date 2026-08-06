namespace mySQL_Projektverwaltung.Tab_Search
{
    partial class SearchControl1
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
            textBox1 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            cb_projID = new System.Windows.Forms.CheckBox();
            cb_LS = new System.Windows.Forms.CheckBox();
            cb_AG = new System.Windows.Forms.CheckBox();
            cb_desc_short = new System.Windows.Forms.CheckBox();
            cb_desc_long = new System.Windows.Forms.CheckBox();
            cb_name = new System.Windows.Forms.CheckBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(718, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(718, 463);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cb_projID
            // 
            cb_projID.AutoSize = true;
            cb_projID.Checked = true;
            cb_projID.CheckState = System.Windows.Forms.CheckState.Checked;
            cb_projID.Location = new System.Drawing.Point(3, 3);
            cb_projID.Name = "cb_projID";
            cb_projID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cb_projID.Size = new System.Drawing.Size(82, 19);
            cb_projID.TabIndex = 4;
            cb_projID.Text = "Projekt Nr.";
            cb_projID.UseVisualStyleBackColor = true;
            cb_projID.CheckedChanged += cb_Load;
            // 
            // cb_LS
            // 
            cb_LS.AutoSize = true;
            cb_LS.Checked = true;
            cb_LS.CheckState = System.Windows.Forms.CheckState.Checked;
            cb_LS.Location = new System.Drawing.Point(155, 3);
            cb_LS.Name = "cb_LS";
            cb_LS.Size = new System.Drawing.Size(75, 19);
            cb_LS.TabIndex = 5;
            cb_LS.Text = "Lehrstuhl";
            cb_LS.UseVisualStyleBackColor = true;
            cb_LS.CheckedChanged += cb_Load;
            // 
            // cb_AG
            // 
            cb_AG.AutoSize = true;
            cb_AG.Checked = true;
            cb_AG.CheckState = System.Windows.Forms.CheckState.Checked;
            cb_AG.Location = new System.Drawing.Point(236, 3);
            cb_AG.Name = "cb_AG";
            cb_AG.Size = new System.Drawing.Size(101, 19);
            cb_AG.TabIndex = 6;
            cb_AG.Text = "Arbeitsgruppe";
            cb_AG.UseVisualStyleBackColor = true;
            cb_AG.CheckedChanged += cb_Load;
            // 
            // cb_desc_short
            // 
            cb_desc_short.AutoSize = true;
            cb_desc_short.Checked = true;
            cb_desc_short.CheckState = System.Windows.Forms.CheckState.Checked;
            cb_desc_short.Location = new System.Drawing.Point(343, 3);
            cb_desc_short.Name = "cb_desc_short";
            cb_desc_short.Size = new System.Drawing.Size(121, 19);
            cb_desc_short.TabIndex = 7;
            cb_desc_short.Text = "Kurzbeschreibung";
            cb_desc_short.UseVisualStyleBackColor = true;
            cb_desc_short.CheckedChanged += cb_Load;
            // 
            // cb_desc_long
            // 
            cb_desc_long.AutoSize = true;
            cb_desc_long.Checked = true;
            cb_desc_long.CheckState = System.Windows.Forms.CheckState.Checked;
            cb_desc_long.Location = new System.Drawing.Point(470, 3);
            cb_desc_long.Name = "cb_desc_long";
            cb_desc_long.Size = new System.Drawing.Size(47, 19);
            cb_desc_long.TabIndex = 8;
            cb_desc_long.Text = "Text";
            cb_desc_long.UseVisualStyleBackColor = true;
            cb_desc_long.CheckedChanged += cb_Load;
            // 
            // cb_name
            // 
            cb_name.AutoSize = true;
            cb_name.Checked = true;
            cb_name.CheckState = System.Windows.Forms.CheckState.Checked;
            cb_name.Location = new System.Drawing.Point(91, 3);
            cb_name.Name = "cb_name";
            cb_name.Size = new System.Drawing.Size(58, 19);
            cb_name.TabIndex = 9;
            cb_name.Text = "Name";
            cb_name.UseVisualStyleBackColor = true;
            cb_name.CheckedChanged += cb_Load;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cb_projID);
            flowLayoutPanel1.Controls.Add(cb_name);
            flowLayoutPanel1.Controls.Add(cb_LS);
            flowLayoutPanel1.Controls.Add(cb_AG);
            flowLayoutPanel1.Controls.Add(cb_desc_short);
            flowLayoutPanel1.Controls.Add(cb_desc_long);
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(708, 26);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // SearchControl1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "SearchControl1";
            Size = new System.Drawing.Size(724, 530);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cb_projID;
        private System.Windows.Forms.CheckBox cb_LS;
        private System.Windows.Forms.CheckBox cb_AG;
        private System.Windows.Forms.CheckBox cb_desc_short;
        private System.Windows.Forms.CheckBox cb_desc_long;
        private System.Windows.Forms.CheckBox cb_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
