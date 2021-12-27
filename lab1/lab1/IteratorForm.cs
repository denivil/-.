using lab1.Iterator;
using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class IteratorForm : Form
    {
        private ImageCollection _imageCollection;

        private IIterator _iterator;
        public IteratorForm()
        {
            InitializeComponent();

            _imageCollection = new ImageCollection(Environment.CurrentDirectory + "\\Images", pictureBox1);

            _iterator = _imageCollection.GetIterator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (System.Drawing.Image)_iterator.Previous();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (System.Drawing.Image)_iterator.Next();
            pictureBox1.Image = (System.Drawing.Image)_iterator.Previous();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (System.Drawing.Image)_iterator.Next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StrategyForm strategyForm = new StrategyForm();

            strategyForm.Show();

            this.Dispose();
        }
    }
}
