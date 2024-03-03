using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdeasAi.db;

namespace IdeasAi.pages
{
    public partial class frm_notebook: Form
    {
        public MainForm mainForm;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel3;
        private Button button4;
        private FlowLayoutPanel pnl_container;

        public frm_notebook(MainForm _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }
        private void InitializeComponent()
        {
            this.pnl_container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pnl_container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.Controls.Add(this.panel1);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(20, 20);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1052, 506);
            this.pnl_container.TabIndex = 0;
            this.pnl_container.AutoSizeChanged += new System.EventHandler(this.pnl_container_AutoSizeChanged);
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 224);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 54);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(226, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 54);
            this.button2.TabIndex = 13;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "DATE CREATED: 2004-09-9867";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title of My Note Here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 63);
            this.panel3.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(309, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 63);
            this.button4.TabIndex = 1;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frm_notebook
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1092, 546);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notebook";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Load += new System.EventHandler(this.frm_notebook_Load);
            this.pnl_container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private bool HasScrollBar(Control control)
        {
            // Check if the control's client size is smaller than its display rectangle
            return control.ClientSize.Width < control.DisplayRectangle.Width ||
                   control.ClientSize.Height < control.DisplayRectangle.Height;
        }
        public void displaySavedIdeas()
        {
            pnl_container.Controls.Clear();
            var saved_ideas = mainForm.dbManager_Idea.GetAllIdeas();

            Console.WriteLine($"OLD: {pnl_container.DisplayRectangle.Height}::{pnl_container.VerticalScroll.Visible}");

            bool verticalScrollBarVisible = false;

            foreach (var idea in saved_ideas)
            {
                Panel pnl_idea = new Panel();
                pnl_idea.BorderStyle = BorderStyle.FixedSingle;
                pnl_idea.BackColor = Color.Gray;
                pnl_idea.Size = new Size((pnl_container.Width / 3) - 6, 200);
                pnl_idea.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

                Label titleLabel = new Label();
                titleLabel.Text = idea.Title;
                titleLabel.Dock = DockStyle.Top;
                titleLabel.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.AutoEllipsis = true;
                titleLabel.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnl_idea.Controls.Add(titleLabel);

                Panel pnl_btns = new Panel();
                pnl_btns.Dock = DockStyle.Bottom;
                pnl_btns.Height = titleLabel.Height + 20;
                pnl_btns.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20); ;


                Button btn_view = new Button();
                btn_view.Text = "View";
                btn_view.Click += (sender, e) => displayNote_click(idea.Content);
                btn_view.Dock = DockStyle.Fill;
                btn_view.FlatStyle = FlatStyle.Flat;

                Button btn_edit = new Button();
                btn_edit.Text = "Edit";
                btn_edit.Click += (sender, e) => displayNote_click(idea.Content);
                btn_edit.Dock = DockStyle.Fill;
                btn_edit.FlatStyle = FlatStyle.Flat;

                Button btn_delete = new Button();
                btn_delete.Text = "Delete";
                btn_delete.Click += (sender, e) => displayNote_click(idea.Content);
                btn_delete.Dock = DockStyle.Fill;
                btn_delete.FlatStyle = FlatStyle.Flat;

                pnl_btns.Controls.Add(btn_view);
                pnl_btns.Controls.Add(btn_delete);
                pnl_btns.Controls.Add(btn_edit);
                pnl_idea.Controls.Add(pnl_btns);
                pnl_btns.Padding = new System.Windows.Forms.Padding(15,0,15,0);

                int BtnSize = ((pnl_btns.Width) / 3);

                btn_view.Size = new Size(BtnSize, pnl_btns.Height - 8) ;
                btn_edit.Size = new Size(BtnSize, pnl_btns.Height - 8) ;
                btn_delete.Size = new Size(BtnSize, pnl_btns.Height - 8) ;

                Label dateLabel = new Label();
                dateLabel.Text = $"Date Created: {idea.DateCreated.Date.ToString("yyyy-MM-dd")}";
                dateLabel.Dock = DockStyle.Bottom;
                dateLabel.TextAlign = ContentAlignment.MiddleCenter;
                dateLabel.Location = new Point(10, 50); // Adjust location as needed
                dateLabel.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnl_idea.Controls.Add(dateLabel);

                pnl_container.Controls.Add(pnl_idea);

                // No need to adjust the width here
            }

            // Check if the vertical scrollbar is visible after adding all ideas
            verticalScrollBarVisible = pnl_container.VerticalScroll.Visible;

            // If the vertical scrollbar is visible, adjust the width of each pnl_idea
            if (verticalScrollBarVisible)
            {
                foreach (Control control in pnl_container.Controls)
                {
                    if (control is Panel pnl_idea)
                    {
                        pnl_idea.Size = new Size((pnl_container.Width / 3) - 6 - (SystemInformation.VerticalScrollBarWidth / 3), 200);

                    }
                }
            }

            Console.WriteLine($"NEW: {pnl_container.DisplayRectangle.Height}::{pnl_container.VerticalScroll.Visible}");
        }


        private void displayNote_click(string content)
        {
            mainForm.loadForm(mainForm.frm_home,mainForm.pnl_content);
            mainForm.setActiveBtn(mainForm.btn_home);
            mainForm.frm_home.displayResult(content);
        }
        private void frm_notebook_Load(object sender, EventArgs e)
        {
            displaySavedIdeas();
        }

        private void pnl_container_AutoSizeChanged(object sender, EventArgs e)
        {
        }

       
    }
}
