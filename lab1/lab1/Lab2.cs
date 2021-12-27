using lab1.Superclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Lab2 : Form
    {
        private Graphics _formGraphics;

        public Lab2()
        {
            InitializeComponent();
        }
        private void Lab2_Load(object sender, EventArgs e)
        {
            _formGraphics = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse(Color.Red, _formGraphics, 250, 150);

            ellipse.Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Color.Black, _formGraphics, 150);

            circle.Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lab1.Superclass.Rectangle rectangle = 
                new Superclass.Rectangle(Color.AliceBlue, _formGraphics, 200, 300);

            rectangle.Draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Square square = new Square(Color.Black, _formGraphics, 200);
           
            square.Draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FactoryForm factory = new FactoryForm();

            factory.Show();
        }
    }
}
