using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        
        double numero1, numero2, resultado;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            txtNum3.Text = String.Empty;
            //ou ainda txtNum3.Text = null;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calma! Ainda esta muito avançado para essa calculadorazinha ; )");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Independente do que você digitou, será 0 dado que são constantes.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi! Ainda não aceitando doações mas me segue no twitter @oanic. Da um oi lá ; )");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
               (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtNum3.Text = resultado.ToString();
            }
            else
            MessageBox.Show("Numeros invalidos!!!");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
               (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtNum3.Text = resultado.ToString();
            }
            else
            MessageBox.Show("Numeros invalidos!!!");
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
               (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtNum3.Text = resultado.ToString();
            }
            else
            MessageBox.Show("Numeros invalidos!!!");
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
               (double.TryParse(txtNum2.Text, out numero2)))
            {
                if (numero2 == 0)
                MessageBox.Show("Denominador não pode ser 0!!!");
                else
                {
                    resultado = numero1 / numero2;
                    txtNum3.Text = resultado.ToString();
                }
            }
            else
            MessageBox.Show("Numeros invalidos!!!");
        }
    }
}