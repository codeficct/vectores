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
        Vector objV1, objV2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objV1 = new Vector();
            objV2 = new Vector();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n1, max, min;
            n1 = int.Parse(textBox1.Text);
            max = int.Parse(textBox2.Text);
            min = int.Parse(textBox3.Text);
            objV1.setNumber(n1, max, min);
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void segmentacionDeEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objV1.SegmentarElementos(ref objV2);
            textBox4.Text = objV2.getNumber();
            Console.ReadLine();
        }
    }
}
