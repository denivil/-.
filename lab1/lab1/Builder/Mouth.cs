using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Builder
{
    internal class Mouth
    {
        private Graphics _graphics;
        private Color _color;

        public Mouth (Graphics graphics, Color color)
        {
            _graphics = graphics;
            _color = color;
        }

        public void Draw(string text)
        {
            _graphics.DrawString(text, new Font("Times New Roman", 24, FontStyle.Regular), new
                SolidBrush(_color), new PointF(100, 10));
        }
    }

}
