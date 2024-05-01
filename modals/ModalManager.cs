using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public class ModalManager
    {
        MainForm mainForm;
        public ModalManager(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public static void ShowModal(MainForm mainForm, Form callerForm, Form modal)
        {
            mainForm.setModalBackground(callerForm);

            modal.Owner = mainForm.modalBG;
            modal.ShowInTaskbar = false;

            AnimationUtils.FadeIn(modal);
            
            modal.ShowDialog();

            mainForm.modalBG.Hide();
            mainForm.Focus();
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