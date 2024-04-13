namespace IdeasAi.PageForms
{
    partial class frm_consultation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.wb_container = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_Consult = new System.Windows.Forms.RichTextBox();
            this.pnl_txbCont = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_toWorkspace = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_txbCont.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.wb_container);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 566);
            this.panel1.TabIndex = 0;
            // 
            // wb_container
            // 
            this.wb_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_container.Location = new System.Drawing.Point(0, 84);
            this.wb_container.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_container.Name = "wb_container";
            this.wb_container.Size = new System.Drawing.Size(880, 430);
            this.wb_container.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.pnl_txbCont);
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(880, 84);
            this.panel2.TabIndex = 5;
            // 
            // txb_Consult
            // 
            this.txb_Consult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.txb_Consult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Consult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_Consult.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Consult.ForeColor = System.Drawing.Color.White;
            this.txb_Consult.Location = new System.Drawing.Point(10, 15);
            this.txb_Consult.Multiline = false;
            this.txb_Consult.Name = "txb_Consult";
            this.txb_Consult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txb_Consult.Size = new System.Drawing.Size(775, 37);
            this.txb_Consult.TabIndex = 2;
            this.txb_Consult.Text = "Ask a question..";
            this.txb_Consult.TextChanged += new System.EventHandler(this.txb_Consult_TextChanged);
            // 
            // pnl_txbCont
            // 
            this.pnl_txbCont.BackColor = System.Drawing.Color.Transparent;
            this.pnl_txbCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_txbCont.Controls.Add(this.txb_Consult);
            this.pnl_txbCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_txbCont.Location = new System.Drawing.Point(15, 15);
            this.pnl_txbCont.Name = "pnl_txbCont";
            this.pnl_txbCont.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.pnl_txbCont.Size = new System.Drawing.Size(797, 54);
            this.pnl_txbCont.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_toWorkspace);
            this.panel3.Controls.Add(this.btn_print);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 514);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel3.Size = new System.Drawing.Size(880, 52);
            this.panel3.TabIndex = 11;
            // 
            // btn_send
            // 
            this.btn_send.AllowDrop = true;
            this.btn_send.BackColor = System.Drawing.Color.White;
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Image = global::IdeasAi.Properties.Resources.send;
            this.btn_send.Location = new System.Drawing.Point(812, 15);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(53, 54);
            this.btn_send.TabIndex = 1;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_toWorkspace
            // 
            this.btn_toWorkspace.BackColor = System.Drawing.Color.White;
            this.btn_toWorkspace.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toWorkspace.Enabled = false;
            this.btn_toWorkspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_toWorkspace.FlatAppearance.BorderSize = 5;
            this.btn_toWorkspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toWorkspace.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toWorkspace.Image = global::IdeasAi.Properties.Resources.workspace_small;
            this.btn_toWorkspace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toWorkspace.Location = new System.Drawing.Point(213, 3);
            this.btn_toWorkspace.Name = "btn_toWorkspace";
            this.btn_toWorkspace.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_toWorkspace.Size = new System.Drawing.Size(154, 49);
            this.btn_toWorkspace.TabIndex = 12;
            this.btn_toWorkspace.Text = "Workspace";
            this.btn_toWorkspace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_toWorkspace.UseVisualStyleBackColor = false;
            this.btn_toWorkspace.Click += new System.EventHandler(this.btn_toWorkspace_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_print.Enabled = false;
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_print.FlatAppearance.BorderSize = 5;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Image = global::IdeasAi.Properties.Resources.print;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(101, 3);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_print.Size = new System.Drawing.Size(112, 49);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_save.FlatAppearance.BorderSize = 5;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::IdeasAi.Properties.Resources.saveAsFile;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(0, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_save.Size = new System.Drawing.Size(101, 49);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // frm_consultation
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(930, 616);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_consultation";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "frm_home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_txbCont.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser wb_container;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox txb_Consult;
        private System.Windows.Forms.Panel pnl_txbCont;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_toWorkspace;
        private System.Windows.Forms.Button btn_print;
    }
}