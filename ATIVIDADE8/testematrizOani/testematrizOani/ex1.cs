using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace testematrizOani
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[20];
            string auxiliar = "";
            string saida = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString(), "Entrada de dados");

                if (double.TryParse(auxiliar, out vetor[i]))
                {
                    saida = vetor[i].ToString() + "\n" + saida;
                }
                else
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }
            }
            MessageBox.Show(saida);
        }
    }
}
