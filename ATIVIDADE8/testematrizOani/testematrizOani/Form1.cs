using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testematrizOani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ex1 abrirex1 = new ex1();
            abrirex1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ex2 abrirex2 = new ex2();
            abrirex2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ex3 abrirex3 = new ex3();
            abrirex3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ex4 abrirex4 = new ex4();
            abrirex4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ex5 abrirex5 = new ex5();
            abrirex5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ex6 abrirex6 = new ex6();
            abrirex6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ex7 abrirex7 = new ex7();
            abrirex7.Show();
        }
    }
}
