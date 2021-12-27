using lab1.Builder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class BuilderForm : Form
    {
        private Graphics _graphics;

        private Director _director;

        public BuilderForm()
        {
            InitializeComponent();

            _graphics = CreateGraphics();

            _director = new Director();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);

            _director.Construct(new GoodBoiBuilder(_graphics));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);

            _director.Construct(new NaturalSmileBuilder(_graphics));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);

            _director.Construct(new BadSmileBuilder(_graphics));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IteratorForm iteratorForm = new IteratorForm();

            iteratorForm.Show();

            this.Dispose();
        }
    }
}
