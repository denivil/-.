using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory
{
    internal class Circle : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawEllipse(pen, 250, 130, 120, 120);
        }
    }
}
