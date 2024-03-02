using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using IdeasAi.db;
using IdeasAi.Ideas;

namespace IdeasAi.modals
{
    public partial class mdl_save : Form
    {
        public Dictionary<string, string> data = new Dictionary<string, string>();
        DatabaseManager dbManager = new DBManager_Idea();
        
        public mdl_save()
        {
            InitializeComponent();
        }

        private void tmr_animation_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                tmr_animation.Stop();
            }
            else
            {
                Opacity += .05;
            }
        }

        private void frm_modal_Load(object sender, EventArgs e)
        {
            kryptonTextBox1.Text = MainForm.instance.frm_home.input_holder;
            var ownerForm = Owner.Owner.Owner;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var idea_save_obj = new Idea();
            idea_save_obj.UUID = MainForm.instance.frm_home.id_holder;
            idea_save_obj.Title = kryptonTextBox1.Text;
            idea_save_obj.Input = MainForm.instance.frm_home.input_holder;
            idea_save_obj.Content = MainForm.instance.frm_home.content_holder;
            idea_save_obj.DateCreated = MainForm.instance.frm_home.date_holder;

            dbManager.SaveObject(idea_save_obj);

            MainForm.instance.loadForm(MainForm.instance.frm_notebook, MainForm.instance.pnl_content);
            MainForm.instance.setActiveBtn(MainForm.instance.getNottebookBtn());
            MainForm.instance.frm_notebook.displaySavedIdeas();

            // Load the notebook form into the content panel
            MainForm.instance.BringToFront();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.BringToFront();
            this.Hide();
        }

        private void panel2_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("close");
        }
    }
}
