using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar dados
            txtAltura.Clear();
            //txtRaio.Text = "";
            txtRaio.Clear();
            txtVolume.Clear();
            txtRaio.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            double altura, raio;

            if (double.TryParse(txtAltura.Text, out altura) &&
                (double.TryParse(txtRaio.Text, out raio)))
            {
                double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Valores Invalidos!");

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //13 é o enter em ascii
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; //desativa o beep
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
