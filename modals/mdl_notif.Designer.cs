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
            this.btn_close = new System.Windows.Forms.Button();
            this.tmr_close = new System.Windows.Forms.Timer(this.components);
            this.pbx_type = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_type)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_type
            // 
            this.pnl_type.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_type.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_type.Location = new System.Drawing.Point(0, 0);
            this.pnl_type.Name = "pnl_type";
            this.pnl_type.Size = new System.Drawing.Size(15, 60);
            this.pnl_type.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::IdeasAi.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(304, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(61, 60);
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
            // pbx_type
            // 
            this.pbx_type.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbx_type.Image = global::IdeasAi.Properties.Resources.success;
            this.pbx_type.Location = new System.Drawing.Point(15, 0);
            this.pbx_type.Name = "pbx_type";
            this.pbx_type.Size = new System.Drawing.Size(53, 60);
            this.pbx_type.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_type.TabIndex = 6;
            this.pbx_type.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lbl_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(68, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 8);
            this.panel1.Size = new System.Drawing.Size(236, 60);
            this.panel1.TabIndex = 7;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoEllipsis = true;
            this.lbl_type.AutoSize = true;
            this.lbl_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_type.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(0, 10);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(50, 22);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoEllipsis = true;
            this.lbl_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_info.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(0, 35);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbl_info.Size = new System.Drawing.Size(236, 17);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "info";
            // 
            // mdl_notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 60);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbx_type);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdl_notif";
            this.Text = "mdl_notif";
            this.Load += new System.EventHandler(this.mdl_notif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_type)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_type;
        public System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pbx_type;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_type;
        public System.Windows.Forms.Label lbl_info;
        public System.Windows.Forms.Timer tmr_close;
    }
}