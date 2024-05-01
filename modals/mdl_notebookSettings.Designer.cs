namespace IdeasAi.modals
{
    partial class mdl_notebookSettings
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_createNew = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_notebookName = new System.Windows.Forms.Label();
            this.txb_noteName = new System.Windows.Forms.TextBox();
            this.btn_browsePath = new System.Windows.Forms.Button();
            this.lbl_savePath = new System.Windows.Forms.Label();
            this.txb_saveDBPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnl_content.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.pnl_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_header.Controls.Add(this.panel8);
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(13, 12);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(510, 62);
            this.pnl_header.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_exit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(447, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(15);
            this.panel8.Size = new System.Drawing.Size(61, 60);
            this.panel8.TabIndex = 16;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_exit.Location = new System.Drawing.Point(15, 15);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 30);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.panel7);
            this.pnl_content.Controls.Add(this.panel6);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(13, 74);
            this.pnl_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(510, 301);
            this.pnl_content.TabIndex = 4;
            this.pnl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_content_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_browse);
            this.panel7.Controls.Add(this.btn_createNew);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 186);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(107, 6, 107, 12);
            this.panel7.Size = new System.Drawing.Size(510, 81);
            this.panel7.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_browse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(107, 38);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(296, 31);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Import";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_createNew
            // 
            this.btn_createNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(229)))), ((int)(((byte)(135)))));
            this.btn_createNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_createNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_createNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNew.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createNew.Location = new System.Drawing.Point(107, 6);
            this.btn_createNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createNew.Name = "btn_createNew";
            this.btn_createNew.Size = new System.Drawing.Size(296, 27);
            this.btn_createNew.TabIndex = 0;
            this.btn_createNew.Text = "Create";
            this.btn_createNew.UseVisualStyleBackColor = false;
            this.btn_createNew.Click += new System.EventHandler(this.btn_createNew_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 267);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(133, 12, 133, 37);
            this.panel6.Size = new System.Drawing.Size(510, 34);
            this.panel6.TabIndex = 0;
            // 
            // lbl_notebookName
            // 
            this.lbl_notebookName.AutoSize = true;
            this.lbl_notebookName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notebookName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_notebookName.Location = new System.Drawing.Point(107, 0);
            this.lbl_notebookName.Name = "lbl_notebookName";
            this.lbl_notebookName.Size = new System.Drawing.Size(107, 16);
            this.lbl_notebookName.TabIndex = 2;
            this.lbl_notebookName.Text = "Notebook name:";
            // 
            // txb_noteName
            // 
            this.txb_noteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_noteName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_noteName.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_noteName.Location = new System.Drawing.Point(107, 32);
            this.txb_noteName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_noteName.Name = "txb_noteName";
            this.txb_noteName.Size = new System.Drawing.Size(296, 25);
            this.txb_noteName.TabIndex = 0;
            this.txb_noteName.Text = "New Notebook";
            this.txb_noteName.TextChanged += new System.EventHandler(this.txb_noteName_TextChanged);
            // 
            // btn_browsePath
            // 
            this.btn_browsePath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_browsePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browsePath.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browsePath.Location = new System.Drawing.Point(350, 39);
            this.btn_browsePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_browsePath.Name = "btn_browsePath";
            this.btn_browsePath.Size = new System.Drawing.Size(53, 24);
            this.btn_browsePath.TabIndex = 5;
            this.btn_browsePath.Text = "...";
            this.btn_browsePath.UseVisualStyleBackColor = true;
            this.btn_browsePath.Click += new System.EventHandler(this.btn_browsePath_Click);
            // 
            // lbl_savePath
            // 
            this.lbl_savePath.AutoSize = true;
            this.lbl_savePath.BackColor = System.Drawing.Color.Transparent;
            this.lbl_savePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_savePath.Location = new System.Drawing.Point(107, 6);
            this.lbl_savePath.Name = "lbl_savePath";
            this.lbl_savePath.Size = new System.Drawing.Size(71, 16);
            this.lbl_savePath.TabIndex = 4;
            this.lbl_savePath.Text = "Save path:";
            // 
            // txb_saveDBPath
            // 
            this.txb_saveDBPath.BackColor = System.Drawing.SystemColors.Window;
            this.txb_saveDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_saveDBPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_saveDBPath.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_saveDBPath.Location = new System.Drawing.Point(107, 38);
            this.txb_saveDBPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_saveDBPath.Name = "txb_saveDBPath";
            this.txb_saveDBPath.ReadOnly = true;
            this.txb_saveDBPath.Size = new System.Drawing.Size(238, 25);
            this.txb_saveDBPath.TabIndex = 3;
            this.txb_saveDBPath.TextChanged += new System.EventHandler(this.txb_saveDBPath_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(13, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 18);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txb_noteName);
            this.panel1.Controls.Add(this.lbl_notebookName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(13, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(107, 0, 107, 6);
            this.panel1.Size = new System.Drawing.Size(510, 63);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(107, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 12);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_browsePath);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbl_savePath);
            this.panel4.Controls.Add(this.txb_saveDBPath);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(13, 155);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(107, 6, 165, 0);
            this.panel4.Size = new System.Drawing.Size(510, 63);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(107, 22);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 10);
            this.panel5.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Image = global::IdeasAi.Properties.Resources.addNotebook;
            this.lbl_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_title.Size = new System.Drawing.Size(508, 60);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "     Add New Notebook";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mdl_notebookSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 387);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mdl_notebookSettings";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ShowInTaskbar = false;
            this.Text = "mdl_noteSettings";
            this.Load += new System.EventHandler(this.mdl_notebookSettings_Load);
            this.pnl_header.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_notebookName;
        private System.Windows.Forms.TextBox txb_noteName;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_createNew;
        private System.Windows.Forms.Label lbl_savePath;
        private System.Windows.Forms.TextBox txb_saveDBPath;
        private System.Windows.Forms.Button btn_browsePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_exit;
    }
}