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
            //Used to Rotate Axis Label Text
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
            DrawBarGraph(graphData.GetItemList());
        }

        private void DrawBarGraph(List<ItemModel> data)
        {
            if(data.Count() > 0)
            {
                BarGraphProp barGraph = DrawAxis(data);

                DrawData(data, barGraph);
            }
        }

        private BarGraphProp DrawAxis(List<ItemModel> data)
        {
            SetPen(Color.Black);
            int width = lblPanel.Width;
            int height = lblPanel.Height;
            const int dist = 50;
            int XAxisMax = 0;
            int YAxisMax = 0;

            //Variables
            int lineSize = 10;
            int YnumOfInc = 10;
            int XnumOfInc = data.Count();
            int counter = 0;
            int textBuffer = 2;
            int yScale = (data.Max(i => i.Data) + 9) / 10 * 10 / YnumOfInc; //Rounds up to nearest tens place divided by 10 (how much each increment increases by)
            Font font = new Font("Ariel", 10, GraphicsUnit.Pixel);
            Point currPoint = Point.Empty;
            Point prevPoint = Point.Empty;

            //Y-axis
            for (int i = height - dist; i >= dist; i -= (height - dist * 2) / YnumOfInc)
            {

                //Measure Number
                SizeF stringSize = TextRenderer.MeasureText(counter.ToString(), font);

                canvas.DrawLine(pen, dist - (lineSize / 2), i, dist + (lineSize / 2), i); //Increment Line
                canvas.DrawString(counter.ToString(), font, new SolidBrush(Color.Black), dist - (lineSize / 2) - stringSize.Width - textBuffer, i - (stringSize.Height / 2) - textBuffer); //Increment Label

                //Draw Axis
                currPoint = new Point(dist, i);
                if (prevPoint != Point.Empty)
                {
                    canvas.DrawLine(pen, prevPoint, currPoint);
                }
                prevPoint = currPoint;

                //Increment
                counter += yScale;

                if(counter <= yScale * YnumOfInc)
                {
                    YAxisMax += (height - dist * 2) / YnumOfInc;
                }
            }

            currPoint = Point.Empty;
            prevPoint = Point.Empty;
            counter = -1;
            //X-axis
            for (int i = dist; i <= width - dist; i += (width - dist * 2) / XnumOfInc)
            {
                if (counter >= 0 && counter < data.Count())
                {
                    string textToWrite = data[counter].Name;

                    //Measure Text
                    SizeF stringSize = TextRenderer.MeasureText(textToWrite, font);

                    //Increment Label
                    canvas.DrawString(textToWrite, font, new SolidBrush(Color.Black), i - (stringSize.Width / 2) + textBuffer, height - dist + (lineSize / 2) + textBuffer);
                }

                //Increment Line
                canvas.DrawLine(pen, i, height - dist - (lineSize / 2), i, height - dist + (lineSize / 2));
                
                //Draw Axis
                currPoint = new Point(i, height - dist);
                if (prevPoint != Point.Empty)
                {
                    canvas.DrawLine(pen, prevPoint, currPoint);
                }
                prevPoint = currPoint;

                //Increment
                counter++;

                XAxisMax = i - dist;
            }

            Axis y = new Axis(yScale, YnumOfInc, YAxisMax, dist);
            Axis x = new Axis(1, XnumOfInc, XAxisMax, height - dist);
            return new BarGraphProp(y, x);
        }

        private void DrawData(List<ItemModel> data, BarGraphProp barGraph)
        {
            Axis Yaxis = barGraph.Y_Axis;
            Axis Xaxis = barGraph.X_Axis;
            int counter = 0;
            int spacing = 30;
            int itemAllotedSpace = Xaxis.Length / Xaxis.IncrementCount;
            
            foreach (ItemModel item in data)
            {
                //SetPen(item.Color);
                canvas.FillRectangle(
                    new SolidBrush(item.Color), 
                    Yaxis.Base + itemAllotedSpace * counter + spacing / 2,
                    Xaxis.Base - (Yaxis.Length / (Yaxis.Scale * Yaxis.IncrementCount) * item.Data),
                    itemAllotedSpace - spacing / 2,
                    Yaxis.Length / (Yaxis.Scale * Yaxis.IncrementCount) * item.Data
                    );

                counter++;
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

        private void graphFrm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = graphData.Title;
            lblYaxis.Text = graphData.Yaxis;
            lblXaxis.Text = graphData.Xaxis;
        }

        private class BarGraphProp
        {
            public Axis Y_Axis { get; set; }
            public Axis X_Axis { get; set; }

            public BarGraphProp(Axis y, Axis x)
            {
                Y_Axis = y;
                X_Axis = x;
            }
        }
        public struct Axis
        {
            public readonly int Scale;
            public readonly int IncrementCount;
            public readonly int Length;
            public readonly int Base;

            public Axis(int Scale, int IncrementCount, int Length, int Base)
            {
                this.Scale = Scale;
                this.IncrementCount = IncrementCount;
                this.Length = Length;
                this.Base = Base;
            }
        }
    }
}
