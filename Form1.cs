using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace graphics
{
    public partial class Form1 : Form
    {
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();

        }

        // Draw Point
        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Blue, p.X,p.Y,10F,10F);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            Invalidate();
        }*/

        //Draw Recatangle || Draw Elipse

        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 25, y = 25, height = 60, width = 60;
            Pen pen = new Pen(Brushes.Red, 4); // 4 - толщина
            Point p = new Point(10, 10);
            Size size = new Size(160, 160);
            Rectangle r1 = new Rectangle(p, size);
            Rectangle r2 = new Rectangle(x, y, height, width);
            g.FillEllipse(Brushes.Aquamarine, r1);
            g.DrawEllipse(pen, r2);
        }*/

        //Draw Line
        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Body Cap (стрелка на конце (StartCap EndCap)) DashStyle - тело линии 
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.DarkSeaGreen, 6);
            pen.StartCap = LineCap.SquareAnchor;
            pen.EndCap = LineCap.Triangle;
            pen.DashStyle = DashStyle.Solid;
            pen.DashCap = DashCap.Round;
            g.DrawLine(pen, 20, 20, 200, 200); //x1,y1,x2,y2
            pen.Dispose();
            g.Dispose();
        }*/

        // Draw Elipse w dash Style
        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.DarkSeaGreen, 6);
            pen.DashStyle = DashStyle.Dot;
            g.DrawEllipse(pen, 100, 100, 150, 70);
            pen.Dispose();
            g.Dispose();
        }*/

        // Gradients
        /* private void Form1_Paint(object sender, PaintEventArgs e)
         {
             Graphics g = e.Graphics;
             Rectangle r1 = new Rectangle(20, 20, 200, 60);
             LinearGradientBrush lgb = new LinearGradientBrush(r1,Color.Azure, Color.Cyan, 0.0f,true);
             g.FillRectangle(lgb, r1);
             Rectangle r2 = new Rectangle(20, 100, 200, 60);
             HatchBrush hb = new HatchBrush(HatchStyle.Cross, Color.Blue);
             g.FillRectangle(hb, r2);
             Rectangle r3 = new Rectangle(20, 180, 200, 60);
             TextureBrush tb = new TextureBrush(new Bitmap("sky.jpg"));
             g.FillRectangle(tb, r3);
             g.Dispose();


         }*/
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 1

            /*Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100);

            g.DrawRectangle(new Pen(Color.Green, 2), new Rectangle(100, 100, 60, 60));

            g.DrawPie(new Pen(Color.Indigo, 3), 150, 10, 150, 150, 90, 180);

            g.DrawString("Hello GDI + !", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 0, 240);

            PointF[] pArray = {
                new PointF(10.0F, 50.0F),
                new PointF(200.0F, 200.0F),
                new PointF(90.0F, 20.0F),
                new PointF(140.0F, 50.0F),
                new PointF(40.0F, 150.0F) 
            };
            g.DrawPolygon(new Pen(Color.GreenYellow, 2), pArray);

            g.DrawEllipse(new Pen(Color.Green, 4), 200, 230, 30, 30);
            g.Dispose();*/

            // 2

            /*Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Point[] points = {
                    new Point(5, 10),
                    new Point(23, 130),
                    new Point(130, 57)};
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddEllipse(170, 170, 100, 50);

            g.FillPath(Brushes.Aqua, path);

            path.StartFigure();
            path.AddCurve(points, 0.5F);
            path.AddArc(100, 50, 100, 100, 0, 120);
            path.AddLine(50, 150, 50, 220);

            path.CloseFigure();

            path.StartFigure();
            path.AddArc(180, 30, 60, 60, 0, -170);
            g.DrawPath(new Pen(Color.Blue, 3), path);
            g.Dispose();*/
        }

    }
}
