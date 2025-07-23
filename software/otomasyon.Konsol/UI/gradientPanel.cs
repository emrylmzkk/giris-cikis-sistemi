using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



namespace Otomasyon.UI
{

    public class GradientPanel : Panel
    {

        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public float Angle { get; set; } = 90f;



        protected override void OnPaint(PaintEventArgs e)
        {
            if (ClientRectangle.Width > 0 && ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Angle))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }


            }

            base.OnPaint(e);
        }

    }


}