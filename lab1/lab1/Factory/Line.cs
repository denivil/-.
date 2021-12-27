using System.Drawing;

namespace lab1.Factory
{
    internal class Line : IDrawable
    {
        public void Draw(Graphics graphycs)
        {
            graphycs.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            graphycs.DrawLine(pen, 150, 250, 300, 250);
        }
    }
}
