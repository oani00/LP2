﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios__oani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 abrirex2 = new Form2();
            abrirex2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_1 abrirex1 = new Form_1();
            abrirex1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 abrirex3 = new Form3();
            abrirex3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 abrirex4 = new Form4();
            abrirex4.Show();
        }
    }
}
