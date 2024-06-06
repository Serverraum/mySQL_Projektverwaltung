namespace mySQL_Projektverwaltung
{
    partial class NewProj_Form
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
            label2 = new System.Windows.Forms.Label();
            tb_email = new System.Windows.Forms.TextBox();
            tb_tel = new System.Windows.Forms.TextBox();
            tb_shortdesc = new System.Windows.Forms.TextBox();
            tb_name = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cb_LS = new System.Windows.Forms.ComboBox();
            cb_AG = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 5);
            label2.Location = new System.Drawing.Point(2, 67);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 15);
            label2.TabIndex = 9;
            label2.Text = "Arbeitsgruppe/Group\r\n";
            // 
            // tb_email
            // 
            tb_email.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_email, 3);
            tb_email.Location = new System.Drawing.Point(48, 183);
            tb_email.Margin = new System.Windows.Forms.Padding(2);
            tb_email.Name = "tb_email";
            tb_email.Size = new System.Drawing.Size(283, 23);
            tb_email.TabIndex = 11;
            // 
            // tb_tel
            // 
            tb_tel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_tel, 3);
            tb_tel.Location = new System.Drawing.Point(48, 153);
            tb_tel.Margin = new System.Windows.Forms.Padding(2);
            tb_tel.Name = "tb_tel";
            tb_tel.Size = new System.Drawing.Size(283, 23);
            tb_tel.TabIndex = 10;
            // 
            // tb_shortdesc
            // 
            tb_shortdesc.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_shortdesc, 4);
            tb_shortdesc.Location = new System.Drawing.Point(12, 273);
            tb_shortdesc.Margin = new System.Windows.Forms.Padding(2);
            tb_shortdesc.Name = "tb_shortdesc";
            tb_shortdesc.Size = new System.Drawing.Size(319, 23);
            tb_shortdesc.TabIndex = 16;
            // 
            // tb_name
            // 
            tb_name.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(tb_name, 3);
            tb_name.Location = new System.Drawing.Point(48, 123);
            tb_name.Margin = new System.Windows.Forms.Padding(2);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(283, 23);
            tb_name.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label7, 5);
            label7.Location = new System.Drawing.Point(2, 247);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(329, 15);
            label7.TabIndex = 17;
            label7.Text = "Kurzbeschreibung/Short Description";
            // 
            // cb_LS
            // 
            cb_LS.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb_LS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            tableLayoutPanel1.SetColumnSpan(cb_LS, 4);
            cb_LS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_LS.Location = new System.Drawing.Point(12, 33);
            cb_LS.Margin = new System.Windows.Forms.Padding(2);
            cb_LS.Name = "cb_LS";
            cb_LS.Size = new System.Drawing.Size(319, 23);
            cb_LS.TabIndex = 4;
            cb_LS.SelectionChangeCommitted += cb_LS_SelectionChangeCommitted;
            // 
            // cb_AG
            // 
            cb_AG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb_AG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            tableLayoutPanel1.SetColumnSpan(cb_AG, 4);
            cb_AG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_AG.FormattingEnabled = true;
            cb_AG.Location = new System.Drawing.Point(12, 93);
            cb_AG.Margin = new System.Windows.Forms.Padding(2);
            cb_AG.Name = "cb_AG";
            cb_AG.Size = new System.Drawing.Size(319, 23);
            cb_AG.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Location = new System.Drawing.Point(2, 127);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Location = new System.Drawing.Point(5, 187);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "eMail:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Location = new System.Drawing.Point(20, 157);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 15);
            label4.TabIndex = 13;
            label4.Text = "Tel:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 5);
            label1.Location = new System.Drawing.Point(2, 7);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Lehrstuhl/Chair";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(tb_email, 2, 6);
            tableLayoutPanel1.Controls.Add(tb_tel, 2, 5);
            tableLayoutPanel1.Controls.Add(tb_shortdesc, 1, 9);
            tableLayoutPanel1.Controls.Add(tb_name, 2, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 8);
            tableLayoutPanel1.Controls.Add(cb_LS, 1, 1);
            tableLayoutPanel1.Controls.Add(cb_AG, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 4, 10);
            tableLayoutPanel1.Controls.Add(button1, 1, 10);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(343, 361);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(255, 335);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += bt_proj_save_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(button1, 3);
            button1.Location = new System.Drawing.Point(13, 335);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Chancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewProj_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(343, 361);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new System.Drawing.Size(193, 400);
            Name = "NewProj_Form";
            Text = "NewProj_Form";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_shortdesc;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_LS;
        private System.Windows.Forms.ComboBox cb_AG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}