﻿namespace IdeasAi.modals
{
    partial class mdl_NotesOptions
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_noteTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_setNoteTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tmr_animation = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 49);
            this.panel1.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(445, 49);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "More settings";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_noteTitle
            // 
            this.lbl_noteTitle.AutoSize = true;
            this.lbl_noteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_noteTitle.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_noteTitle.Location = new System.Drawing.Point(46, 50);
            this.lbl_noteTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lbl_noteTitle.Name = "lbl_noteTitle";
            this.lbl_noteTitle.Size = new System.Drawing.Size(73, 15);
            this.lbl_noteTitle.TabIndex = 3;
            this.lbl_noteTitle.Text = "Note title:";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(46, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 8);
            this.panel3.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(46, 183);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(353, 28);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(46, 175);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 8);
            this.panel4.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(46, 147);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(353, 28);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.txb_setNoteTitle);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_noteTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(60, 65, 60, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(46, 50, 46, 50);
            this.panel2.Size = new System.Drawing.Size(445, 261);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txb_setNoteTitle
            // 
            this.txb_setNoteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_setNoteTitle.Location = new System.Drawing.Point(46, 73);
            this.txb_setNoteTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_setNoteTitle.Multiline = true;
            this.txb_setNoteTitle.Name = "txb_setNoteTitle";
            this.txb_setNoteTitle.Size = new System.Drawing.Size(353, 31);
            this.txb_setNoteTitle.StateActive.Content.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txb_setNoteTitle.StateActive.Content.Padding = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.txb_setNoteTitle.TabIndex = 10;
            this.txb_setNoteTitle.Text = "My Title";
            this.txb_setNoteTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_setNoteTitle_KeyDown);
            // 
            // tmr_animation
            // 
            this.tmr_animation.Enabled = true;
            this.tmr_animation.Interval = 1;
            this.tmr_animation.Tick += new System.EventHandler(this.tmr_animation_Tick);
            // 
            // mdl_NotesOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(445, 310);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mdl_NotesOptions";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "mdl_editNotes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_noteTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_setNoteTitle;
        private System.Windows.Forms.Timer tmr_animation;
    }
}