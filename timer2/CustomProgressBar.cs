using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer2
{
    //Credit to: https://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5
    public class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaintBackground(PaintEventArgs pevent) //Stops the flickering
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 1;

            using (Image offscreenImage = new Bitmap(Width, Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, Width, Height);

                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(-inset, -inset);
                    rect.Width = (int)(rect.Width * ((double)Value / Maximum));

                    if (rect.Width == 0)
                        rect.Width = 1;

                    LinearGradientBrush brush = new LinearGradientBrush(rect, Color.DarkBlue, Color.DodgerBlue, LinearGradientMode.Horizontal);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                }
            }
        }
    }
}
