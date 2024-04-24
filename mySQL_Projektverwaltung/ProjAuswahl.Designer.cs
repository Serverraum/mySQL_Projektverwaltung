namespace mySQL_Projektverwaltung
{
    partial class ProjAuswahl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new System.Windows.Forms.TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeView1.Location = new System.Drawing.Point(14, 14);
            treeView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            treeView1.Name = "treeView1";
            treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            treeView1.RightToLeftLayout = true;
            treeView1.ShowRootLines = false;
            treeView1.Size = new System.Drawing.Size(233, 508);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // ProjAuswahl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(261, 537);
            Controls.Add(treeView1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(277, 2302);
            MinimumSize = new System.Drawing.Size(137, 225);
            Name = "ProjAuswahl";
            Text = "Form1";
            TopMost = true;
            Load += ProjAuswahl_Load;
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
    }
}