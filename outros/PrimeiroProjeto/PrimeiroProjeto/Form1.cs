﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bom Dia "+textBox1.Text + "\n" + " seja vem vindo(a) a FATEC");
            // isso e um comentario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
