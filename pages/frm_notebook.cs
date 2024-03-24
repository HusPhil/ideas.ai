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
using IdeasAi.modals;

namespace IdeasAi.pages
{
    public partial class frm_notebook: Form
    {
        public string current_title;
        public Guid current_id;
        public MainForm mainForm;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel3;
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 63);
            this.panel3.TabIndex = 11;
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
            var saved_ideas = mainForm.dbManager_Idea.getAllIdeas();

            Console.WriteLine($"OLD: {pnl_container.DisplayRectangle.Height}::{pnl_container.VerticalScroll.Visible}");

            bool verticalScrollBarVisible = false;

            foreach (var idea in saved_ideas)
            {
                Panel pnl_idea = new Panel();
                pnl_idea.BorderStyle = BorderStyle.FixedSingle;
                pnl_idea.BackColor = Color.Gray;
                pnl_idea.Size = new Size((pnl_container.Width / 3) - 6, 200);
                pnl_idea.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

                Panel pnl_header = new Panel();
                pnl_header.BorderStyle = BorderStyle.None;
                pnl_header.Dock = DockStyle.Top;
                pnl_header.Size = new Size(50,50);
                pnl_header.Padding = new Padding(0, 0, 20, 0);


                Button btn_edit = new Button();
                btn_edit.Image = global::IdeasAi.Properties.Resources.more;
                btn_edit.Click += (sender, e) => btn_showMore_click(idea.Title, idea.UUID);
                btn_edit.BackColor = Color.Transparent;
                btn_edit.AutoSize = false;
                btn_edit.Size = new Size(32, 32);
                btn_edit.Dock = DockStyle.Right;
                btn_edit.FlatStyle = FlatStyle.Flat;
                btn_edit.FlatAppearance.BorderSize = 0;
                btn_edit.Margin = new Padding(0,0,20,0);

                Label titleLabel = new Label();
                titleLabel.Text = idea.Title;
                titleLabel.Dock = DockStyle.Top;
                titleLabel.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.AutoEllipsis = true;
                titleLabel.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnl_idea.Controls.Add(titleLabel);
                pnl_header.Controls.Add(btn_edit);

                pnl_idea.Controls.Add(pnl_header);

                Panel pnl_btns = new Panel();
                pnl_btns.Dock = DockStyle.Bottom;
                pnl_btns.Height = titleLabel.Height + 20;
                pnl_btns.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20); ;


                Button btn_view = new Button();
                btn_view.Text = "View";
                btn_view.Click += (sender, e) => displayNote_click(idea.Content);
                btn_view.Dock = DockStyle.Fill;
                btn_view.FlatStyle = FlatStyle.Flat;

                pnl_btns.Controls.Add(btn_view);
                pnl_idea.Controls.Add(pnl_btns);
                pnl_btns.Padding = new System.Windows.Forms.Padding(15,0,15,0);

                int BtnSize = ((pnl_btns.Width) / 3);

                btn_view.Size = new Size(BtnSize, pnl_btns.Height - 8) ;

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

        private void btn_showMore_click(string current_title, Guid current_id)
        {
            this.current_title = current_title;
            this.current_id = current_id;
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_editNotes), mainForm);
        }
        private void displayNote_click(string content)
        {
            mainForm.loadForm(mainForm.frm_home,mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnHome());
            mainForm.frm_home.displayResult(content);
            mainForm.frm_home.getSaveBtn().Enabled = false;
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
