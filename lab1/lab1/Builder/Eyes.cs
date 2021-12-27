using System.Drawing;

namespace lab1.Builder
{
    internal class Eyes
    {
        private Color _color;
        private Graphics _graphics;

        public Eyes(Color color, Graphics graphics)
        {
            _color = color;
            _graphics = graphics;
        }

        public void Draw(string text)
        {
            _graphics.DrawString(text, new Font("Times New Roman", 24, FontStyle.Regular), new
                SolidBrush(_color), new PointF(10, 10));
        }
    }
}
