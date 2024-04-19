namespace IdeasAi.modals
{
    partial class mdl_howToUse
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.lbl_content = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_okay = new System.Windows.Forms.Button();
            this.tmr_animation = new System.Windows.Forms.Timer(this.components);
            this.pnl_header.SuspendLayout();
            this.pnl_Content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(679, 77);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "How To Use?";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(679, 77);
            this.pnl_header.TabIndex = 1;
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.pnl_Content.Controls.Add(this.lbl_content);
            this.pnl_Content.Controls.Add(this.panel1);
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Content.Location = new System.Drawing.Point(0, 77);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_Content.Size = new System.Drawing.Size(679, 352);
            this.pnl_Content.TabIndex = 2;
            // 
            // lbl_content
            // 
            this.lbl_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.lbl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_content.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_content.Location = new System.Drawing.Point(15, 15);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_content.Size = new System.Drawing.Size(649, 262);
            this.lbl_content.TabIndex = 0;
            this.lbl_content.Text = "label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btn_okay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(15, 277);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(280, 10, 280, 10);
            this.panel1.Size = new System.Drawing.Size(649, 60);
            this.panel1.TabIndex = 2;
            // 
            // btn_okay
            // 
            this.btn_okay.BackColor = System.Drawing.Color.White;
            this.btn_okay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okay.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okay.Location = new System.Drawing.Point(280, 10);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(89, 40);
            this.btn_okay.TabIndex = 1;
            this.btn_okay.Text = "OKAY";
            this.btn_okay.UseVisualStyleBackColor = false;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // tmr_animation
            // 
            this.tmr_animation.Enabled = true;
            this.tmr_animation.Interval = 1;
            this.tmr_animation.Tick += new System.EventHandler(this.tmr_animation_Tick);
            // 
            // mdl_howToUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(679, 429);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdl_howToUse";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "mdl_howToUse";
            this.Load += new System.EventHandler(this.mdl_howToUse_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_Content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.Timer tmr_animation;
    }
}