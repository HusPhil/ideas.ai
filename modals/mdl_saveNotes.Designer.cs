namespace IdeasAi.modals
{
    partial class mdl_saveNotes
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_setNoteTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_noteTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Image = global::IdeasAi.Properties.Resources.saveIcon;
            this.lbl_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_title.Size = new System.Drawing.Size(565, 58);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "    Do you want to Save this in Notebook?";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 60);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb_setNoteTitle);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.lbl_noteTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(61, 62, 61, 62);
            this.panel2.Size = new System.Drawing.Size(567, 298);
            this.panel2.TabIndex = 3;
            // 
            // txb_setNoteTitle
            // 
            this.txb_setNoteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_setNoteTitle.Location = new System.Drawing.Point(61, 89);
            this.txb_setNoteTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_setNoteTitle.Multiline = true;
            this.txb_setNoteTitle.Name = "txb_setNoteTitle";
            this.txb_setNoteTitle.Size = new System.Drawing.Size(445, 38);
            this.txb_setNoteTitle.StateActive.Content.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txb_setNoteTitle.StateActive.Content.Padding = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.txb_setNoteTitle.TabIndex = 10;
            this.txb_setNoteTitle.Text = "My Note #1";
            this.txb_setNoteTitle.TextChanged += new System.EventHandler(this.txb_setNoteTitle_TextChanged);
            this.txb_setNoteTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_setNoteTitle_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(61, 198);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(444, 34);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(61, 226);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 10);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(61, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 10);
            this.panel3.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(229)))), ((int)(((byte)(135)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(61, 159);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(444, 34);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_noteTitle
            // 
            this.lbl_noteTitle.AutoSize = true;
            this.lbl_noteTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_noteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_noteTitle.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_noteTitle.Location = new System.Drawing.Point(61, 62);
            this.lbl_noteTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_noteTitle.Name = "lbl_noteTitle";
            this.lbl_noteTitle.Size = new System.Drawing.Size(192, 17);
            this.lbl_noteTitle.TabIndex = 3;
            this.lbl_noteTitle.Text = "Give this note a title:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(13, 348);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 22);
            this.panel5.TabIndex = 4;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // mdl_saveNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(593, 382);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mdl_saveNotes";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ShowInTaskbar = false;
            this.Text = "frm_modal";
            this.Load += new System.EventHandler(this.frm_modal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_noteTitle;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_setNoteTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}