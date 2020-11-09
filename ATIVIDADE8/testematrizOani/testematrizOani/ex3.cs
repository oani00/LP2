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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar matrizes
            double[] quantidade = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] preco = new double[10] {0,0,0,0,0,0,0,0,0,0};
            
            //receber via inputbox
            //calcular faturamento
            double faturamento = 0;
            string saida = "";
            string auxiliar = "";
            

            for (var i = 0; i < 10; i++)
            {

                auxiliar = Interaction.InputBox("Diga a quantidade do produto " + (i + 1).ToString(), "Entrada de dados");
                if (!double.TryParse(auxiliar, out quantidade[i]))
                { 
                    MessageBox.Show("Número inválido");
                    i--;
                }

                auxiliar = Interaction.InputBox("Diga o preço do produto " + (i + 1).ToString(), "Entrada de dados");
                if (!double.TryParse(auxiliar, out preco[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }

                faturamento = quantidade[i] * preco[i];
                saida = saida + "Faturamento do item " + (i + 1).ToString() + "= " + faturamento.ToString() + "\n";

            }

            //mostrar medias numa string
            MessageBox.Show(saida);

        }
    }
}
