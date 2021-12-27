using lab1.Superclass;
using System.Drawing;

namespace lab1.Builder
{
    internal class Head
    {
        private Graphics _graphics;
        private Color _color;

        public Head(Color color, Graphics graphics)
        {
            _color = color;

            _graphics = graphics;
        }

        public void Draw()
        {
            Pen pen = new Pen(_color, 2);

            _graphics.DrawEllipse(pen, 10, 10, 50, 50);
        }
    }
}
