using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        IntegerNumbers objV1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objV1 = new IntegerNumbers();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n1, a, b;
            n1 = int.Parse(textBox1.Text);
            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox3.Text);
            objV1.setNumber(n1, a, b);
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.getNumber();
        }
    }
}
