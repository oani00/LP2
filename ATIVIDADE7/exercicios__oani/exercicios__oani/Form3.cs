using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPal_Click(object sender, EventArgs e)
        {
            //-S ESPAÇOS e MAIUSCULO OK

            txtPal.Text = txtPal.Text.Replace(" ", "");
            txtPal.Text = txtPal.Text.ToUpper();

            //-criar inverso //baseado no ex de sala OK

            string inverso = "";

            char[] auxiliar = txtPal.Text.ToCharArray();
            Array.Reverse(auxiliar);
            foreach (char c in auxiliar)
                inverso += c;

            //-checar se o inverso == normal
            //-Display

            if (String.Compare(txtPal.Text, inverso, true) == 0) //o true ignora case sensitive
                MessageBox.Show("O que você digitou foi: \n" + txtPal.Text + "\ne É um palindromo");
            else
                MessageBox.Show("O que você digitou foi: \n" + txtPal.Text + "\ne NAO um palindromo");

        }
    }
}
