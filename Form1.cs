using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic;

namespace Vectores
{
    public partial class Form1 : Form
    {
        Vector objV1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objV1 = new Vector();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int value, max, min;
            value = int.Parse(textBox1.Text);
            min = int.Parse(textBox2.Text);
            max = int.Parse(textBox3.Text);
            objV1.setNumber(value, max, min);
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.getNumber();
        }

        private void countPrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.CountPrime().ToString();
        }

        private void getMaxNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.getMaxMin(true).ToString();
        }

        private void getMinNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.getMaxMin(false).ToString();
        }

        private void ordenarVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.OrderMethod();
        }

        private void cargarElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n, index;
            
            n = int.Parse(Interaction.InputBox("Dimen:"));
            for (index = 0; index < n; index++)
                objV1.Set(1 );
        }

        private void contarElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // textBox4.Text = objV1.countRepeatsElements().ToString();
            textBox4.Text = objV1.countNumElements().ToString();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int value, max, min;
            value = int.Parse(textBox1.Text);
            min = int.Parse(textBox2.Text);
            max = int.Parse(textBox3.Text);
            objV1.setNumber(value, max, min);
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objV1.getNumber();
        }
    }
}
