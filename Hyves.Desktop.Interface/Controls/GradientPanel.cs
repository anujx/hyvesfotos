using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Hyves.Desktop.Interface
{
    public class GradientPanel : Panel
    {
        public GradientPanel(): base()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Color color1 = Color.FromArgb(255,229,163);
            Color color2 = Color.FromArgb(253, 178, 51);


            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, color1 , color2, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
            br.Dispose();
            base.OnPaint(e);
        }
    }
}
