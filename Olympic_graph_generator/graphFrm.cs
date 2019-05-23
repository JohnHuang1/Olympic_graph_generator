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
        Graphics canvas;
        Pen pen;
        public graphFrm(GraphDataModel graphData)
        {
            InitializeComponent();
            this.graphData = graphData;
            canvas = lblPanel.CreateGraphics();
            SetPen(Color.Blue, 1);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void lblYaxis_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = lblYaxis;
            Font font = lblYaxis.Font;
            e.Graphics.TranslateTransform(lbl.Width / 2, lbl.Height / 2);
            e.Graphics.RotateTransform(270);
            SizeF textSize = TextRenderer.MeasureText("Yaxis", font);
            e.Graphics.DrawString("Yaxis", font, new SolidBrush(Color.Black), -(textSize.Width / 2), -(textSize.Height / 2));
            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            canvas.DrawLine(pen, 0, 0, lblPanel.Height, lblPanel.Width);
            DrawBarGraph();
        }

        private void DrawBarGraph()
        {
            DrawAxis();
        }

        private void DrawAxis()
        {
            SetPen(Color.Black);
            int width = lblPanel.Width;
            int height = lblPanel.Height;
            int dist = 50;

            //Draw Main Line
            //canvas.DrawLines(pen, new Point[] { new Point(dist, dist), new Point(dist, height - dist), new Point(width - dist, height - dist) });

            //Draw Axis Increment
            //Variables
            int lineSize = 10;
            int YnumOfInc = 100;
            int XnumOfInc = 5;
            int counter = 0;
            int textBuffer = 2;
            int incrementAmount = 1;
            Font font = new Font("Ariel", 10, GraphicsUnit.Pixel);
            Point currPoint = Point.Empty;
            Point prevPoint = Point.Empty;

            //Y-axis
            for (int i = height - dist; i >= dist; i -= (height - dist*2) / YnumOfInc)
            {
                //Measure Number
                SizeF stringSize = TextRenderer.MeasureText(counter.ToString(), font);

                canvas.DrawLine(pen, dist - (lineSize / 2), i, dist + (lineSize / 2), i);
                canvas.DrawString(counter.ToString(), font, new SolidBrush(Color.Black), dist - (lineSize / 2) - stringSize.Width - textBuffer, i - (stringSize.Height / 2) - textBuffer);
                currPoint = new Point(dist, i);
                if (prevPoint != Point.Empty)
                {
                    canvas.DrawLine(pen, prevPoint, currPoint);
                }
                prevPoint = currPoint;

                //Increment
                counter += incrementAmount;
            }
            
            currPoint = Point.Empty;
            prevPoint = Point.Empty;
            //X-axis
            for (int i = dist; i <= width - dist; i += (height - dist*2) / XnumOfInc)
            {
                //Measure Number
                SizeF stringSize = TextRenderer.MeasureText(counter.ToString(), font);

                canvas.DrawLine(pen, i, height - dist - (lineSize / 2), i, height - dist + (lineSize / 2));
                canvas.DrawString(counter.ToString(), font, new SolidBrush(Color.Black), i - (stringSize.Width / 2) - textBuffer, (height - dist) + (lineSize / 2) + textBuffer);
                currPoint = new Point(i, height - dist);
                if (prevPoint != Point.Empty)
                {
                    canvas.DrawLine(pen, prevPoint, new Point(dist, i));
                }
                prevPoint = currPoint;

                //Increment
                counter += incrementAmount;
            }
            
        }

        private void SetPen(Color color, int width)
        {
            pen = new Pen(color, width);
        }
        private void SetPen(Color color)
        {
            pen = new Pen(color, pen.Width);
        }
        private void SetPen(int width)
        {
            pen = new Pen(pen.Color, width);
        }

    }
}
