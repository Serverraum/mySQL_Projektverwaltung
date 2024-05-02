using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace howto_edit_picture_list
{
    partial class PictureList
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
            this.components = new System.ComponentModel.Container();
            this.panPictures = new howto_edit_picture_list.PictureList.SelectablePanel();
            this.ctxPictures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMoveLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeletePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.ctxPictures.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPictures
            // 
            this.panPictures.AllowDrop = true;
            this.panPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPictures.AutoScroll = true;
            this.panPictures.AutoSize = true;
            this.panPictures.BackColor = System.Drawing.Color.White;
            this.panPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panPictures.ContextMenuStrip = this.ctxPictures;
            this.panPictures.Location = new System.Drawing.Point(43, 3);
            this.panPictures.Name = "panPictures";
            this.panPictures.Size = new System.Drawing.Size(221, 277);
            this.panPictures.TabIndex = 4;
            this.panPictures.TabStop = true;
            this.panPictures.KeyDown += new System.EventHandler<System.Windows.Forms.KeyEventArgs>(this.panPictures_KeyDown);
            this.panPictures.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panPictures_Scroll);
            this.panPictures.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureList_DragDrop);
            this.panPictures.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureList_DragEnter);
            this.panPictures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panPictures_MouseDown);
            this.panPictures.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panPictures_MouseWheel);
            this.panPictures.Resize += new System.EventHandler(this.panPictures_Resize);
            // 
            // ctxPictures
            // 
            this.ctxPictures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoveLeft,
            this.mnuMoveRight,
            this.mnuDeletePicture,
            this.mnuInsertPicture});
            this.ctxPictures.Name = "ctxPictures";
            this.ctxPictures.Size = new System.Drawing.Size(157, 92);
            // 
            // mnuMoveLeft
            // 
            this.mnuMoveLeft.Name = "mnuMoveLeft";
            this.mnuMoveLeft.Size = new System.Drawing.Size(156, 22);
            this.mnuMoveLeft.Text = "Move &Left";
            this.mnuMoveLeft.Click += new System.EventHandler(this.mnuMoveLeft_Click);
            // 
            // mnuMoveRight
            // 
            this.mnuMoveRight.Name = "mnuMoveRight";
            this.mnuMoveRight.Size = new System.Drawing.Size(156, 22);
            this.mnuMoveRight.Text = "Move &Right";
            this.mnuMoveRight.Click += new System.EventHandler(this.mnuMoveRight_Click);
            // 
            // mnuDeletePicture
            // 
            this.mnuDeletePicture.Name = "mnuDeletePicture";
            this.mnuDeletePicture.Size = new System.Drawing.Size(156, 22);
            this.mnuDeletePicture.Text = "&Delete Picture...";
            this.mnuDeletePicture.Click += new System.EventHandler(this.mnuDeletePicture_Click);
            // 
            // mnuInsertPicture
            // 
            this.mnuInsertPicture.Name = "mnuInsertPicture";
            this.mnuInsertPicture.Size = new System.Drawing.Size(156, 22);
            this.mnuInsertPicture.Text = "&Insert Picture...";
            this.mnuInsertPicture.Click += new System.EventHandler(this.mnuInsertPicture_Click);
            // 
            // ofdPicture
            // 
            this.ofdPicture.DefaultExt = "png";
            this.ofdPicture.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All FIles|*.*";
            this.ofdPicture.Multiselect = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panPictures, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_left, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_right, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 283);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bt_left
            // 
            this.bt_left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_left.Location = new System.Drawing.Point(3, 3);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(34, 277);
            this.bt_left.TabIndex = 3;
            this.bt_left.Text = "<";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // bt_right
            // 
            this.bt_right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_right.AutoSize = true;
            this.bt_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_right.Location = new System.Drawing.Point(270, 3);
            this.bt_right.MinimumSize = new System.Drawing.Size(0, 40);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(34, 277);
            this.bt_right.TabIndex = 5;
            this.bt_right.Text = ">";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // PictureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(130, 50);
            this.Name = "PictureList";
            this.Size = new System.Drawing.Size(307, 283);
            this.ctxPictures.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxPictures;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveRight;
        private System.Windows.Forms.ToolStripMenuItem mnuDeletePicture;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertPicture;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_right;
        //private System.Windows.Forms.Panel panPictures;
        private SelectablePanel panPictures;



        class SelectablePanel : Panel
        {
            public SelectablePanel()
            {
                this.SetStyle(ControlStyles.Selectable, true);
                this.TabStop = true;
            }
            protected override bool IsInputKey(Keys keyData)
            {
                //if (keyData == Keys.Up || keyData == Keys.Down) return true;
                if (keyData == Keys.Left || keyData == Keys.Right) return true;
                //if (keyData == Keys.Control) return true;
                return base.IsInputKey(keyData);
            }
            protected override void OnKeyDown(KeyEventArgs e)
            {
                var handler = KeyDown;
                if (handler != null) handler(this, e);
            }
            protected override void OnKeyPress(KeyPressEventArgs e)
            {
                var handler = KeyPress;
                if (handler != null) handler(this, e);
            }
            protected override void OnKeyUp(KeyEventArgs e)
            {
                var handler = KeyUp;
                if (handler != null) handler(this, e);
            }
            protected override void OnMouseEnter(EventArgs e)
            {
                this.Focus();
                base.OnMouseEnter(e);
            }
            protected override void OnEnter(EventArgs e)
            {
                this.Invalidate();
                base.OnEnter(e);
            }
            protected override void OnLeave(EventArgs e)
            {
                this.Invalidate();
                base.OnLeave(e);
            }
            protected override void OnPaint(PaintEventArgs pe)
            {
                base.OnPaint(pe);
                if (this.Focused)
                {
                    var rc = this.ClientRectangle;
                    rc.Inflate(-2, -2);
                    ControlPaint.DrawFocusRectangle(pe.Graphics, rc);
                }
            }

            [Browsable(true)]
            public new event EventHandler<KeyEventArgs> KeyDown;
            [Browsable(true)]
            public new event EventHandler<KeyEventArgs> KeyUp;
            [Browsable(true)]
            public new event EventHandler<KeyPressEventArgs> KeyPress;
        }

    }
}
