using lab1.Factory;
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
    public partial class FactoryForm : Form
    {
        private Graphics _formGraphics;
        private ShapeFabric _shapeFabric;

        public FactoryForm()
        {
            InitializeComponent();
        }

        private void Factory_Load(object sender, EventArgs e)
        {
            _formGraphics = CreateGraphics();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            _shapeFabric = new ShapeFabric(_formGraphics);

            _shapeFabric.CreateShape((int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuilderForm builder = new BuilderForm();

            builder.Show();

            this.Dispose();

        }
    }
}
