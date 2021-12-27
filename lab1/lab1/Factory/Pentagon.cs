using System.Drawing;

namespace lab1.Factory
{
    internal class Pentagon : IDrawable
    {
        public void Draw(Graphics graphycs)
        {
            graphycs.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            PointF point1 = new PointF(250, 150);

            PointF point2 = new PointF(400, 200);

            PointF point3 = new PointF(300, 250);

            PointF point4 = new PointF(200, 250);

            PointF point5 = new PointF(100, 200);

            PointF[] points = { point1, point2, point3, point4, point5 };

            graphycs.DrawPolygon(pen, points);
        }
    }
}
