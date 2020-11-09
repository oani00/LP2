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
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Com ajuda de Luiz Miguel
            
            double[] vetor = new double[20];
            string auxiliar = "";
            string saida = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString(), "Entrada de dados");

                if (!double.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }
                
            }
            //Metodo reverse.

            Array.Reverse(vetor);
            for (int i = 0; i < vetor.Length; i++)
                saida += $"\n{vetor[i]}";

            MessageBox.Show(saida);



        }
    }
}
