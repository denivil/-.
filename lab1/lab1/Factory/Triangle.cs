using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory
{
    internal class Triangle : IDrawable
    {
        public void Draw(Graphics graphycs)
        {
           graphycs.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            PointF point1 = new PointF(250, 130);

            PointF point2 = new PointF(260, 260);

            PointF point3 = new PointF(100, 260);

            PointF[] points = { point1, point2, point3 };

            graphycs.DrawPolygon(pen, points);
        }
    }
}
