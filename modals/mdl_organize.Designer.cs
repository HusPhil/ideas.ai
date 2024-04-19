namespace IdeasAi.modals
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.pnl_selectMode = new System.Windows.Forms.Panel();
            this.cb_modeSelector = new System.Windows.Forms.ComboBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lb_organize = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
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
            this.pnl_footer.Location = new System.Drawing.Point(22, 428);
            this.pnl_footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(751, 87);
            this.pnl_footer.TabIndex = 0;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_buttons.Controls.Add(this.btn_save);
            this.pnl_buttons.Controls.Add(this.btn_go);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_buttons.Location = new System.Drawing.Point(449, 0);
            this.pnl_buttons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.pnl_buttons.Size = new System.Drawing.Size(300, 85);
            this.pnl_buttons.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(239)))), ((int)(((byte)(140)))));
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(22, 23);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 39);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(239)))), ((int)(((byte)(140)))));
            this.btn_go.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_go.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.ForeColor = System.Drawing.Color.Black;
            this.btn_go.Location = new System.Drawing.Point(210, 23);
            this.btn_go.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(68, 39);
            this.btn_go.TabIndex = 0;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // pnl_selectMode
            // 
            this.pnl_selectMode.BackColor = System.Drawing.Color.Transparent;
            this.pnl_selectMode.Controls.Add(this.cb_modeSelector);
            this.pnl_selectMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selectMode.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_selectMode.Location = new System.Drawing.Point(0, 0);
            this.pnl_selectMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_selectMode.Name = "pnl_selectMode";
            this.pnl_selectMode.Padding = new System.Windows.Forms.Padding(22, 23, 0, 0);
            this.pnl_selectMode.Size = new System.Drawing.Size(200, 85);
            this.pnl_selectMode.TabIndex = 6;
            // 
            // cb_modeSelector
            // 
            this.cb_modeSelector.AutoCompleteCustomSource.AddRange(new string[] {
            "Summarizer",
            "Grammar Checker",
            "Expand Ideas",
            "Categorize Ideas",
            "SCAMPER Technique",
            "Random Word Technique",
            ""});
            this.cb_modeSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_modeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_modeSelector.FormattingEnabled = true;
            this.cb_modeSelector.Items.AddRange(new object[] {
            "Summarizer",
            "Grammar Checker",
            "Expand Ideas",
            "Categorize Ideas",
            "SCAMPER Technique"});
            this.cb_modeSelector.Location = new System.Drawing.Point(22, 23);
            this.cb_modeSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_modeSelector.Name = "cb_modeSelector";
            this.cb_modeSelector.Size = new System.Drawing.Size(178, 28);
            this.cb_modeSelector.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.pnl_header.Controls.Add(this.lb_organize);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(22, 62);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(751, 86);
            this.pnl_header.TabIndex = 0;
            // 
            // lb_organize
            // 
            this.lb_organize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_organize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_organize.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_organize.Location = new System.Drawing.Point(0, 0);
            this.lb_organize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_organize.Name = "lb_organize";
            this.lb_organize.Size = new System.Drawing.Size(751, 86);
            this.lb_organize.TabIndex = 0;
            this.lb_organize.Text = "Organize your Ideas!";
            this.lb_organize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(728, 17);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 35);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(22, 403);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 25);
            this.panel3.TabIndex = 2;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_body.Controls.Add(this.txb_preview);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_body.Location = new System.Drawing.Point(22, 173);
            this.pnl_body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.pnl_body.Size = new System.Drawing.Size(751, 230);
            this.pnl_body.TabIndex = 3;
            // 
            // txb_preview
            // 
            this.txb_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_preview.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_preview.Location = new System.Drawing.Point(22, 23);
            this.txb_preview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_preview.Name = "txb_preview";
            this.txb_preview.Size = new System.Drawing.Size(705, 182);
            this.txb_preview.TabIndex = 5;
            this.txb_preview.Text = "This is Preview";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(22, 148);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(751, 25);
            this.panel4.TabIndex = 4;
            // 
            // mdl_organize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 538);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mdl_organize";
            this.Padding = new System.Windows.Forms.Padding(22, 62, 22, 23);
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
        private System.Windows.Forms.ComboBox cb_modeSelector;
        private System.Windows.Forms.Panel pnl_selectMode;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_go;
    }
}