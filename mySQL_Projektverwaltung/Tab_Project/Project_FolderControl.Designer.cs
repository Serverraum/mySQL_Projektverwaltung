﻿namespace mySQL_Projektverwaltung.Tab_Project
{
    partial class Project_FolderControl
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
            button1 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            listView1 = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(54, 188);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(84, 55);
            button1.TabIndex = 0;
            button1.Text = "Change Project-Folder";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(68, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(296, 79);
            listBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(54, 249);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(391, 139);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Incoming files: ";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(370, 49);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 47);
            button2.TabIndex = 4;
            button2.Text = "Download Files";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(144, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(301, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(159, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(266, 15);
            label2.TabIndex = 6;
            label2.Text = "(Max 15MB - MediumBLOB or 4 GB - LargeBLOB)";
            // 
            // Project_FolderControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Project_FolderControl";
            Size = new System.Drawing.Size(516, 504);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}