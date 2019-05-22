using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympic_graph_generator
{
    public partial class graphFrm : Form
    {
        GraphDataModel graphData = new GraphDataModel();
        public graphFrm(GraphDataModel graphData)
        {
            InitializeComponent();
            this.graphData = graphData;            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void graphFrm_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = lblPanel.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 1);
            canvas.DrawLine(bluePen, 0, 0, lblPanel.Height, lblPanel.Width);
        }

        private void lblYaxis_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = lblYaxis;
            Font font = lblYaxis.Font;
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(lbl.Width / 2, lbl.Height / 2);
            e.Graphics.RotateTransform(270);
            SizeF textSize = TextRenderer.MeasureText("Yaxis", font);
            e.Graphics.DrawString("Yaxis", font, brush, -(textSize.Width / 2), -(textSize.Height / 2));
            
        }
    }
}
