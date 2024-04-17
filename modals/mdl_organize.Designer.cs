﻿namespace IdeasAi.modals
{
    partial class mdl_organize
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
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_selectMode = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_organize = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.txb_preview = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_footer.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_selectMode.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_footer.Controls.Add(this.pnl_buttons);
            this.pnl_footer.Controls.Add(this.pnl_selectMode);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_footer.Location = new System.Drawing.Point(15, 278);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(500, 57);
            this.pnl_footer.TabIndex = 0;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_buttons.Controls.Add(this.button2);
            this.pnl_buttons.Controls.Add(this.button1);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_buttons.Location = new System.Drawing.Point(298, 0);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_buttons.Size = new System.Drawing.Size(200, 55);
            this.pnl_buttons.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(239)))), ((int)(((byte)(140)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(15, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(239)))), ((int)(((byte)(140)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(140, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnl_selectMode
            // 
            this.pnl_selectMode.BackColor = System.Drawing.Color.Transparent;
            this.pnl_selectMode.Controls.Add(this.comboBox1);
            this.pnl_selectMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selectMode.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_selectMode.Location = new System.Drawing.Point(0, 0);
            this.pnl_selectMode.Name = "pnl_selectMode";
            this.pnl_selectMode.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.pnl_selectMode.Size = new System.Drawing.Size(133, 55);
            this.pnl_selectMode.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Summarizer",
            "Grammar Checker",
            "Expand Ideas",
            "Categorize Ideas",
            "SCAMPER Technique",
            "Random Word Technique",
            ""});
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Summarizer",
            "Grammar Checker",
            "Expand Ideas",
            "Categorize Ideas",
            "SCAMPER Technique"});
            this.comboBox1.Location = new System.Drawing.Point(15, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.pnl_header.Controls.Add(this.lb_organize);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(15, 40);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(500, 56);
            this.pnl_header.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(485, 11);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_organize
            // 
            this.lb_organize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_organize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_organize.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_organize.Location = new System.Drawing.Point(0, 0);
            this.lb_organize.Name = "lb_organize";
            this.lb_organize.Size = new System.Drawing.Size(500, 56);
            this.lb_organize.TabIndex = 0;
            this.lb_organize.Text = "Organize your Ideas!";
            this.lb_organize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(15, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 16);
            this.panel3.TabIndex = 2;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_body.Controls.Add(this.txb_preview);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_body.Location = new System.Drawing.Point(15, 112);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_body.Size = new System.Drawing.Size(500, 150);
            this.pnl_body.TabIndex = 3;
            // 
            // txb_preview
            // 
            this.txb_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_preview.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_preview.Location = new System.Drawing.Point(15, 15);
            this.txb_preview.Name = "txb_preview";
            this.txb_preview.Size = new System.Drawing.Size(468, 118);
            this.txb_preview.TabIndex = 5;
            this.txb_preview.Text = "This is Preview";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(15, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 16);
            this.panel4.TabIndex = 4;
            // 
            // mdl_organize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdl_organize";
            this.Padding = new System.Windows.Forms.Padding(15, 40, 15, 15);
            this.Text = "mdl_organize";
            this.Load += new System.EventHandler(this.mdl_organize_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_selectMode.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox txb_preview;
        private System.Windows.Forms.Label lb_organize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnl_selectMode;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}