using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory
{
    internal class ShapeFabric
    {
        private IDrawable _shape;
        private Graphics _graphics;

        public ShapeFabric(Graphics graphycs)
        {
            _graphics = graphycs;
        }

        public void CreateShape(int sidesCount)
        {
            if (sidesCount == 0)
            {
                _shape = new Circle();
            }
            else if (sidesCount == 1)
            {
                _shape = new Line();
            }
            else if (sidesCount == 2)
            {
                _shape = new Angle();
            }
            else if (sidesCount == 3)
            {
                _shape = new Triangle();
            }
            else if (sidesCount == 4)
            {
                _shape = new Qube();
            }
            else if (sidesCount == 5)
            {
                _shape = new Pentagon();
            }
            _shape.Draw(_graphics);
        }        
    }
}
