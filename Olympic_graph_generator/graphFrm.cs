using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
        private class AxisProp
        {
            public Axis Y_Axis { get; set; }
            public Axis X_Axis { get; set; }

            public AxisProp(Axis y, Axis x)
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

        GraphDataModel graphData = new GraphDataModel();
        Graphics canvas;
        Pen pen;
        const int distBuffer = 50;
        int canvasHeight, canvasWidth;

        public GraphDataModel.GraphType GType;

        public graphFrm(GraphDataModel graphData)
        {
            InitializeComponent();
            this.graphData = graphData;
            canvas = lblPanel.CreateGraphics();
            SetPen(Color.Blue, 1);
            GType = graphData.gType;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            
            try
            {
                Control control = grpGraph;
                Bitmap captureBitmap = new Bitmap(control.Width, control.Height, PixelFormat.Format32bppRgb);
                Graphics graphics = Graphics.FromImage(captureBitmap);
                Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
                graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = graphData.Title + "_" + GType.ToString();
                saveFileDialog.Filter = "Bitmap Image|*.bmp|Gif Image|*.gif|JPeg Image|*.jpg";
                saveFileDialog.Title = "Save Graph Image";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    System.IO.FileStream fs =
                        (System.IO.FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            captureBitmap.Save(fs, ImageFormat.Bmp);
                            break;

                        case 2:
                            captureBitmap.Save(fs, ImageFormat.Gif);
                            break;

                        case 3:
                            captureBitmap.Save(fs, ImageFormat.Jpeg);
                            break;
                    }

                    fs.Close();
                }
                MessageBox.Show("Screen Captured");

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            switch (GType)
            {
                case GraphDataModel.GraphType.BarGraph:
                    DrawBarGraph(graphData.GetItemList());
                    break;
                case GraphDataModel.GraphType.PieChart:
                    DrawPieChart(graphData.GetItemList());
                    break;
                case GraphDataModel.GraphType.LineGraph:
                    DrawLineGraph(graphData.GetItemList());
                    break;
                default:
                    MessageBox.Show("A graph type was not chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private AxisProp DrawAxis(List<ItemModel> data)
        {
            SetPen(Color.Black);
            int XAxisMax = 0;
            int YAxisMax = 0;

            //Variables
            int lineSize = 10;
            int YnumOfInc = 10;
            int XnumOfInc = data.Count();
            int counter = 0;
            int textBuffer = 2;
            int yScale = (data.Max(i => i.Data) + 9) / 10 * 10 / YnumOfInc; //Rounds up to nearest tens place divided by 10 (how much each increment increases by)
            Font font = new Font("Ariel", 12, GraphicsUnit.Pixel);
            Point currPoint = Point.Empty;
            Point prevPoint = Point.Empty;

            //Y-axis
            for (int i = canvasHeight - distBuffer; i >= distBuffer; i -= (canvasHeight - distBuffer * 2) / YnumOfInc)
            {

                //Measure Number
                SizeF stringSize = TextRenderer.MeasureText(counter.ToString(), font);

                canvas.DrawLine(pen, distBuffer - (lineSize / 2), i, distBuffer + (lineSize / 2), i); //Increment Line
                canvas.DrawString(counter.ToString(), font, new SolidBrush(Color.Black), distBuffer - (lineSize / 2) - stringSize.Width - textBuffer, i - (stringSize.Height / 2) - textBuffer); //Increment Label

                //Draw Axis
                currPoint = new Point(distBuffer, i);
                if (prevPoint != Point.Empty)
                {
                    canvas.DrawLine(pen, prevPoint, currPoint);
                }
                prevPoint = currPoint;

                //Increment
                counter += yScale;

                if(counter <= yScale * YnumOfInc)
                {
                    YAxisMax += (canvasHeight - distBuffer * 2) / YnumOfInc;
                }
            }

            currPoint = Point.Empty;
            prevPoint = Point.Empty;
            counter = -1;
            //X-axis
            for (int i = distBuffer; i <= canvasWidth - distBuffer; i += (canvasWidth - distBuffer * 2) / XnumOfInc)
            {
                if (counter >= 0 && counter < data.Count())
                {
                    string textToWrite = data[counter].Name;

                    //Measure Text
                    SizeF stringSize = TextRenderer.MeasureText(textToWrite, font);

                    //Increment Label
                    canvas.DrawString(textToWrite, font, new SolidBrush(Color.Black), (i - (canvasWidth - distBuffer * 2) / XnumOfInc / 2) - (stringSize.Width / 2) + textBuffer, canvasHeight - distBuffer + (lineSize / 2) + textBuffer);
                }

                //Increment Line
                canvas.DrawLine(pen, i, canvasHeight - distBuffer - (lineSize / 2), i, canvasHeight - distBuffer + (lineSize / 2));
                
                //Draw Axis
                currPoint = new Point(i, canvasHeight - distBuffer);
                if (prevPoint != Point.Empty)
                {
                    canvas.DrawLine(pen, prevPoint, currPoint);
                }
                prevPoint = currPoint;

                //Increment
                counter++;

                XAxisMax = i - distBuffer;
            }

            //Enabled Axis Label
            lblYaxis.Visible = true;
            lblXaxis.Visible = true;

            Axis y = new Axis(yScale, YnumOfInc, YAxisMax, distBuffer);
            Axis x = new Axis(1, XnumOfInc, XAxisMax, canvasHeight - distBuffer);
            return new AxisProp(y, x);
        }

        private void DrawBarData(List<ItemModel> data, AxisProp axis)
        {
            Axis Yaxis = axis.Y_Axis;
            Axis Xaxis = axis.X_Axis;
            int counter = 0;
            int spacing = 30;
            int itemAllotedSpace = Xaxis.Length / Xaxis.IncrementCount;
            SetPen(Color.Black, 1);
            
            foreach (ItemModel item in data)
            {
                RectangleF rect = new RectangleF(
                    Yaxis.Base + itemAllotedSpace * counter + spacing / 2,
                    Xaxis.Base - (Yaxis.Length / (Yaxis.Scale * Yaxis.IncrementCount) * item.Data),
                    itemAllotedSpace - spacing / 2,
                    Yaxis.Length / (Yaxis.Scale * Yaxis.IncrementCount) * item.Data
                    );
                canvas.FillRectangle(new SolidBrush(item.Color), rect);
                canvas.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

                counter++;
            }
        }

        private void DrawBarGraph(List<ItemModel> data)
        {
            AxisProp barGraph = DrawAxis(data);
            DrawBarData(data, barGraph);
        }

        private void DrawLineData(List<ItemModel> data, AxisProp axis)
        {
            Axis Yaxis = axis.Y_Axis;
            Axis Xaxis = axis.X_Axis;
            PointF prev = PointF.Empty;
            SetPen(Color.Black, 2);
            Color lineColor = Color.Black;
            int dotSize = 5;
            int counter = 0;  
            
            foreach(ItemModel item in data)
            {
                PointF itemPoint = new PointF(Yaxis.Base + (Xaxis.Length / Xaxis.IncrementCount) * (float)(counter + .5), Xaxis.Base - (Yaxis.Length / (Yaxis.Scale * Yaxis.IncrementCount) * item.Data));

                //DrawDot
                RectangleF border = new RectangleF( new PointF( itemPoint.X - (dotSize / 2), itemPoint.Y - (dotSize / 2)), new Size(dotSize, dotSize));
                canvas.FillPie(new SolidBrush(lineColor),border.X, border.Y, border.Size.Width, border.Size.Height, 0, 360); //Broke "border" into different variables since the overload that takes a Rectangle object doesn't take Rectangle F

                //DrawLine
                if(prev != Point.Empty)
                {
                    canvas.DrawLine(pen, prev, itemPoint);
                }

                prev = itemPoint;
                counter++;
            }
        }

        private void DrawLineGraph(List<ItemModel> data)
        {
            AxisProp barGraph = DrawAxis(data);
            DrawLineData(data, barGraph);
        }

        private void DrawPieChart(List<ItemModel> data)
        {
            canvas.Clear(Color.White);
            SetPen(Color.Black, 2);
            Font font = new Font("Ariel", 14, GraphicsUnit.Pixel);
            float total = data.Sum(n => n.Data);
            Rectangle border = new Rectangle(distBuffer, distBuffer, canvasWidth - distBuffer * 2, canvasWidth - distBuffer * 2);
            float prevAngle = 0;
            int textBuffer = 5;
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            foreach (ItemModel item in data)
            {
                float sweepAngle = item.Data / total * 360;
                Size stringSize = TextRenderer.MeasureText(item.Name, font);
                canvas.FillPie(new SolidBrush(item.Color), border, prevAngle, sweepAngle);

                canvas.DrawLine(pen, canvasWidth / 2, canvasHeight / 2,
                    (float)Math.Round(canvasWidth / 2 + border.Width / 2 * Math.Cos(prevAngle * (Math.PI / 180)), 2),
                    (float)Math.Round(canvasHeight / 2 + border.Height / 2 * Math.Sin(prevAngle * (Math.PI / 180)), 2)
                    );

                canvas.DrawString(item.Data + "\n" + item.Name, font, new SolidBrush(Color.Black),
                    (float)Math.Round(canvasWidth / 2 + ((border.Width / 2 + stringSize.Width / 2 + textBuffer) * Math.Cos((prevAngle + (sweepAngle / 2)) * (Math.PI / 180))), 2),
                    (float)Math.Round(canvasHeight / 2 + ((border.Height / 2 + stringSize.Height / 2 + textBuffer) * Math.Sin((prevAngle + (sweepAngle / 2)) * (Math.PI / 180))), 2),
                    format
                    );

                prevAngle += sweepAngle;
            }

            SetPen(2);
            canvas.DrawPie(pen, border, 0, 360);
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
            lblYaxis.NewText = graphData.Yaxis;
            lblXaxis.Text = graphData.Xaxis;

            canvasHeight = lblPanel.Height;
            canvasWidth = lblPanel.Width;
        }

    }
}
