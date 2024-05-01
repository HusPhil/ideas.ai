using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public class AnimationUtils
    {
        public static void FadeIn(Form form, int interval = 20)
        {
            form.Opacity = 0;
            Timer timer = new Timer { Interval = interval };
            timer.Tick += (sender, e) =>
            {
                if (form.Opacity >= 1)
                {
                    timer.Stop();
                }
                else
                {
                    form.Opacity += 0.05;
                }
            };
            timer.Start();
        }

        public static void FadeOut(Form form, int interval = 20)
        {
            Timer timer = new Timer { Interval = interval };
            timer.Tick += (sender, e) =>
            {
                if (form.Opacity <= 0)
                {
                    form.Close(); // Close the form when opacity reaches zero
                    timer.Stop();
                }
                else
                {
                    form.Opacity -= 0.05;
                }
            };
            timer.Start();
        }


        public static void SlideIn(Form form, int interval = 10)
        {
            int startY = form.Top - form.Height;
            int targetY = form.Top;
            form.Top = startY;

            Timer timer = new Timer { Interval = interval };
            timer.Tick += (sender, e) =>
            {
                if (form.Top >= targetY)
                {
                    form.Top = targetY;
                    timer.Stop();
                }
                else
                {
                    form.Top += Math.Max(1, (int)((targetY - startY) / (double)interval)); // Ensure the form moves at least 1 pixel per tick
                }
            };
            timer.Start();
        }
    }
}
