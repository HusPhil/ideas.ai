namespace IdeasAi.modals
{
    partial class mdl_notif
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
            this.pnl_type = new System.Windows.Forms.Panel();
            this.pnl_notifBody = new System.Windows.Forms.Panel();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pbx_type = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.tmr_close = new System.Windows.Forms.Timer(this.components);
            this.pnl_notifBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_type)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_type
            // 
            this.pnl_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.pnl_type.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_type.Location = new System.Drawing.Point(0, 0);
            this.pnl_type.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_type.Name = "pnl_type";
            this.pnl_type.Size = new System.Drawing.Size(11, 49);
            this.pnl_type.TabIndex = 0;
            // 
            // pnl_notifBody
            // 
            this.pnl_notifBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_notifBody.Controls.Add(this.lbl_type);
            this.pnl_notifBody.Controls.Add(this.lbl_info);
            this.pnl_notifBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_notifBody.Location = new System.Drawing.Point(51, 0);
            this.pnl_notifBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_notifBody.Name = "pnl_notifBody";
            this.pnl_notifBody.Padding = new System.Windows.Forms.Padding(0, 8, 0, 6);
            this.pnl_notifBody.Size = new System.Drawing.Size(177, 49);
            this.pnl_notifBody.TabIndex = 7;
            this.pnl_notifBody.MouseLeave += new System.EventHandler(this.pnl_notifBody_MouseLeave);
            this.pnl_notifBody.MouseHover += new System.EventHandler(this.pnl_notifBody_MouseHover);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoEllipsis = true;
            this.lbl_type.AutoSize = true;
            this.lbl_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_type.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(0, 8);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 18);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type";
            this.lbl_type.MouseLeave += new System.EventHandler(this.lbl_type_MouseLeave);
            this.lbl_type.MouseHover += new System.EventHandler(this.lbl_type_MouseHover);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoEllipsis = true;
            this.lbl_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_info.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(0, 29);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lbl_info.Size = new System.Drawing.Size(177, 14);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "info";
            this.lbl_info.MouseLeave += new System.EventHandler(this.lbl_type_MouseLeave);
            this.lbl_info.MouseHover += new System.EventHandler(this.lbl_type_MouseHover);
            // 
            // pbx_type
            // 
            this.pbx_type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbx_type.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbx_type.Image = global::IdeasAi.Properties.Resources.success;
            this.pbx_type.Location = new System.Drawing.Point(11, 0);
            this.pbx_type.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_type.Name = "pbx_type";
            this.pbx_type.Size = new System.Drawing.Size(40, 49);
            this.pbx_type.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_type.TabIndex = 6;
            this.pbx_type.TabStop = false;
            this.pbx_type.Click += new System.EventHandler(this.pbx_type_Click);
            this.pbx_type.MouseLeave += new System.EventHandler(this.pbx_type_MouseLeave);
            this.pbx_type.MouseHover += new System.EventHandler(this.pbx_type_MouseHover);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            this.btn_close.BackgroundImage = global::IdeasAi.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(228, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 49);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tmr_close
            // 
            this.tmr_close.Enabled = true;
            this.tmr_close.Interval = 1000;
            this.tmr_close.Tick += new System.EventHandler(this.tmr_close_Tick);
            // 
            // mdl_notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 49);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_notifBody);
            this.Controls.Add(this.pbx_type);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mdl_notif";
            this.Text = "mdl_notif";
            this.Load += new System.EventHandler(this.mdl_notif_Load);
            this.pnl_notifBody.ResumeLayout(false);
            this.pnl_notifBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_type)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_type;
        public System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pbx_type;
        private System.Windows.Forms.Panel pnl_notifBody;
        public System.Windows.Forms.Label lbl_type;
        public System.Windows.Forms.Label lbl_info;
        public System.Windows.Forms.Timer tmr_close;
    }
}