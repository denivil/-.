using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory
{
    internal class Angle : IDrawable
    {
        public void Draw(Graphics graphycs)
        {
           graphycs.Clear(Color.White);

           Pen pen = new Pen(Color.Black, 5);

            graphycs.DrawLine(pen, 100, 150, 300, 150);

            graphycs.DrawLine(pen, 300, 250, 100, 150);
        }
    }
}
