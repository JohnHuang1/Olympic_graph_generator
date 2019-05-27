using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

class RotatedLabel : Label
{
    //public int RotateAngle { get; set; }  // to rotate your text
    public string NewText { get; set; }   // to draw text
    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Brush b = new SolidBrush(ForeColor);
        g.TranslateTransform(Width / 2, Height / 2);
        g.RotateTransform(270);
        SizeF textSize = TextRenderer.MeasureText(NewText, Font);
        g.DrawString(NewText, Font, b, -(textSize.Width / 2), -(textSize.Height / 2));
        base.OnPaint(e);
    }
}