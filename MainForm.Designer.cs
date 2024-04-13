

namespace IdeasAi
{
    partial class MainForm
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pnl_menuSect = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnl_pageTabCont = new System.Windows.Forms.Panel();
            this.pnl_pageTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_consultation = new System.Windows.Forms.Button();
            this.btn_notebook = new System.Windows.Forms.Button();
            this.btn_workspace = new System.Windows.Forms.Button();
            this.btn_mindmap = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.lbl_currentPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_menuSect)).BeginInit();
            this.pnl_menuSect.SuspendLayout();
            this.pnl_pageTabCont.SuspendLayout();
            this.pnl_pageTabs.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.LabelStyles.LabelCommon.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.LabelStyles.LabelCommon.StateNormal.ShortText.Font = new System.Drawing.Font("Cascadia Code Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.LabelStyles.LabelCommon.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.LabelStyles.LabelCommon.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            // 
            // pnl_menuSect
            // 
            this.pnl_menuSect.Controls.Add(this.pnl_pageTabCont);
            this.pnl_menuSect.Controls.Add(this.pnl_header);
            this.pnl_menuSect.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menuSect.Location = new System.Drawing.Point(0, 0);
            this.pnl_menuSect.Name = "pnl_menuSect";
            this.pnl_menuSect.Palette = this.kryptonPalette1;
            this.pnl_menuSect.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.pnl_menuSect.Size = new System.Drawing.Size(320, 720);
            this.pnl_menuSect.TabIndex = 0;
            // 
            // pnl_pageTabCont
            // 
            this.pnl_pageTabCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_pageTabCont.Controls.Add(this.pnl_pageTabs);
            this.pnl_pageTabCont.Controls.Add(this.btn_exit);
            this.pnl_pageTabCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_pageTabCont.Location = new System.Drawing.Point(0, 133);
            this.pnl_pageTabCont.Name = "pnl_pageTabCont";
            this.pnl_pageTabCont.Padding = new System.Windows.Forms.Padding(25, 30, 25, 50);
            this.pnl_pageTabCont.Size = new System.Drawing.Size(320, 587);
            this.pnl_pageTabCont.TabIndex = 2;
            // 
            // pnl_pageTabs
            // 
            this.pnl_pageTabs.BackColor = System.Drawing.Color.Transparent;
            this.pnl_pageTabs.Controls.Add(this.btn_home);
            this.pnl_pageTabs.Controls.Add(this.btn_consultation);
            this.pnl_pageTabs.Controls.Add(this.btn_notebook);
            this.pnl_pageTabs.Controls.Add(this.btn_workspace);
            this.pnl_pageTabs.Controls.Add(this.btn_mindmap);
            this.pnl_pageTabs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_pageTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_pageTabs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_pageTabs.Location = new System.Drawing.Point(25, 30);
            this.pnl_pageTabs.Name = "pnl_pageTabs";
            this.pnl_pageTabs.Padding = new System.Windows.Forms.Padding(1);
            this.pnl_pageTabs.Size = new System.Drawing.Size(270, 332);
            this.pnl_pageTabs.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(4, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(5);
            this.btn_home.Size = new System.Drawing.Size(269, 59);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_consultation
            // 
            this.btn_consultation.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultation.FlatAppearance.BorderSize = 0;
            this.btn_consultation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_consultation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_consultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultation.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultation.ForeColor = System.Drawing.Color.White;
            this.btn_consultation.Location = new System.Drawing.Point(4, 69);
            this.btn_consultation.Name = "btn_consultation";
            this.btn_consultation.Padding = new System.Windows.Forms.Padding(5);
            this.btn_consultation.Size = new System.Drawing.Size(269, 59);
            this.btn_consultation.TabIndex = 8;
            this.btn_consultation.Text = "Consult";
            this.btn_consultation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultation.UseVisualStyleBackColor = false;
            this.btn_consultation.Click += new System.EventHandler(this.btn_consultation_Click);
            // 
            // btn_notebook
            // 
            this.btn_notebook.BackColor = System.Drawing.Color.Transparent;
            this.btn_notebook.FlatAppearance.BorderSize = 0;
            this.btn_notebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_notebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_notebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notebook.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notebook.ForeColor = System.Drawing.Color.White;
            this.btn_notebook.Location = new System.Drawing.Point(4, 134);
            this.btn_notebook.Name = "btn_notebook";
            this.btn_notebook.Padding = new System.Windows.Forms.Padding(5);
            this.btn_notebook.Size = new System.Drawing.Size(269, 59);
            this.btn_notebook.TabIndex = 5;
            this.btn_notebook.Text = "Notebook";
            this.btn_notebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_notebook.UseVisualStyleBackColor = false;
            this.btn_notebook.Click += new System.EventHandler(this.btn_notebook_Click);
            // 
            // btn_workspace
            // 
            this.btn_workspace.BackColor = System.Drawing.Color.Transparent;
            this.btn_workspace.FlatAppearance.BorderSize = 0;
            this.btn_workspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_workspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_workspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workspace.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_workspace.ForeColor = System.Drawing.Color.White;
            this.btn_workspace.Location = new System.Drawing.Point(4, 199);
            this.btn_workspace.Name = "btn_workspace";
            this.btn_workspace.Padding = new System.Windows.Forms.Padding(5);
            this.btn_workspace.Size = new System.Drawing.Size(269, 59);
            this.btn_workspace.TabIndex = 1;
            this.btn_workspace.Text = "Workspace";
            this.btn_workspace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_workspace.UseVisualStyleBackColor = false;
            this.btn_workspace.Click += new System.EventHandler(this.btn_workspace_Click);
            // 
            // btn_mindmap
            // 
            this.btn_mindmap.BackColor = System.Drawing.Color.Transparent;
            this.btn_mindmap.FlatAppearance.BorderSize = 0;
            this.btn_mindmap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_mindmap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_mindmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mindmap.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mindmap.ForeColor = System.Drawing.Color.White;
            this.btn_mindmap.Location = new System.Drawing.Point(4, 264);
            this.btn_mindmap.Name = "btn_mindmap";
            this.btn_mindmap.Padding = new System.Windows.Forms.Padding(5);
            this.btn_mindmap.Size = new System.Drawing.Size(269, 59);
            this.btn_mindmap.TabIndex = 6;
            this.btn_mindmap.Text = "Mindmap";
            this.btn_mindmap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mindmap.UseVisualStyleBackColor = false;
            this.btn_mindmap.Click += new System.EventHandler(this.btn_mindmap_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(25, 478);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5);
            this.btn_exit.Size = new System.Drawing.Size(270, 59);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(320, 133);
            this.pnl_header.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ideas.ai";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonPalette2.ButtonStyles.ButtonBreadCrumb.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_content);
            this.panel1.Controls.Add(this.lbl_currentPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(320, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(960, 720);
            this.panel1.TabIndex = 3;
            // 
            // pnl_content
            // 
            this.pnl_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(15, 89);
            this.pnl_content.Margin = new System.Windows.Forms.Padding(12);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.pnl_content.Size = new System.Drawing.Size(930, 616);
            this.pnl_content.TabIndex = 4;
            // 
            // lbl_currentPage
            // 
            this.lbl_currentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.lbl_currentPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_currentPage.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentPage.ForeColor = System.Drawing.Color.White;
            this.lbl_currentPage.Location = new System.Drawing.Point(15, 15);
            this.lbl_currentPage.Name = "lbl_currentPage";
            this.lbl_currentPage.Padding = new System.Windows.Forms.Padding(12);
            this.lbl_currentPage.Size = new System.Drawing.Size(930, 74);
            this.lbl_currentPage.TabIndex = 3;
            this.lbl_currentPage.Text = "Page 1";
            this.lbl_currentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_menuSect);
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_menuSect)).EndInit();
            this.pnl_menuSect.ResumeLayout(false);
            this.pnl_pageTabCont.ResumeLayout(false);
            this.pnl_pageTabs.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_menuSect;
        private System.Windows.Forms.FlowLayoutPanel pnl_pageTabs;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private System.Windows.Forms.Button btn_workspace;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_currentPage;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_notebook;
        private System.Windows.Forms.Button btn_mindmap;
        private System.Windows.Forms.Button btn_consultation;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_pageTabCont;
        private System.Windows.Forms.Button btn_exit;
    }
}

