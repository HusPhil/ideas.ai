using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public class ModalSetter
    {
        public Form OwnerForm { get; set; }
        public Type ModalFormType { get; set; } 
        public Form ModalForm { get; set; }
        public ModalSetter(Form _owner, Type _frm_modal)
        {
            this.OwnerForm = _owner;
            this.ModalFormType = _frm_modal;
        }

        public void openModal()
        {

            Form modalBG = new Form();
            using (var modal = (Form)Activator.CreateInstance(ModalFormType))
            {
                modalBG.Owner = OwnerForm;
                modalBG.StartPosition = FormStartPosition.Manual;
                modalBG.FormBorderStyle = FormBorderStyle.None;
                modalBG.Opacity = .50d;
                modalBG.BackColor = Color.Black;
                modalBG.Size = OwnerForm.Owner.Size;
                modalBG.Location = OwnerForm.Owner.Location;
                modalBG.ShowInTaskbar = false;
                modalBG.Show();
                modal.Owner = modalBG;

                foreach(var c in modal.Controls)
                {

                }
                modal.ShowDialog();
                modalBG.Dispose();
            }
        }

        public static Point CenterLocation(int cont_width, int cont_height, int item_width, int item_height)
        {
            return new Point((cont_width / 2) - (item_height / 2), (cont_height / 2) - (item_height / 2));
        }
        public static Point CenterLocation(int cont_width, int cont_height, int item_width, int item_height, int offsetX, int offsetY)
        {
            return new Point(offsetX + (cont_width / 2) - (item_width / 2), offsetY + (cont_height / 2) - (item_height / 2));
        }
    }

    
}
