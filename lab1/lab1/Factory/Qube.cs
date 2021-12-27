using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory
{
    internal class Qube : IDrawable
    {
        public void Draw(Graphics graphycs)
        {
            graphycs.Clear(Color.White);
            
            Pen pen = new Pen(Color.Black, 5);

            graphycs.DrawRectangle(pen, 255, 120, 150, 150);
        }
    }

}
