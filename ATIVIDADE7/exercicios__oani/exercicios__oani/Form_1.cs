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
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            //O número de espaços em branco que existem na frase

            //-transformar para array
            char[] auxiliar = richTextBox1.Text.ToCharArray();

            //-checar cada celula
            //-se for " " conta +1

            int posicao = 0, contador = 0;
            while (posicao < richTextBox1.TextLength)
            {
                if (char.IsWhiteSpace(auxiliar[posicao]))
                {
                    contador++;
                    posicao++;
                }
                else
                    posicao++;
            }

            //-display

            txtBranco.Text = Convert.ToString(contador);

        }

        private void btnNVezes_Click(object sender, EventArgs e)
        {
            //O número de vezes que aparece a letra “R”

            //-transformar para array
            char[] auxiliar = richTextBox1.Text.ToCharArray();

            //-checar cada celula
            //-se for "R" conta +1
                //https://stackoverflow.com/questions/5340564/counting-how-many-times-a-certain-char-appears-in-a-string-before-any-other-char

            int contador = 0;

            foreach (char c in auxiliar)
                if(c == 'R')
                    contador++;
            
            //-display

            txtR.Text = Convert.ToString(contador);
        }

        private void btnPardLetras_Click(object sender, EventArgs e)
        {
            //baseado no codigo de Luiz Miguel https://github.com/LuizJarduli/LP2/blob/master/ATIVIDADE7/frmExercicio1.cs
            //-transformar para array
            string frase = richTextBox1.Text;
            char[] auxiliar = richTextBox1.Text.ToCharArray();

            //-checar cada celula
                //-se i-1 == i conta +1
            
            int contador = 0;
            
            for (int i = 0; i < frase.Length; i++)
            {
                if (i > 0)
                {
                    if (frase[i-1] == frase[i])
                    {
                        contador++;
                    }
                }
            }
                

            //-display

            txtVezes.Text = Convert.ToString(contador);
        }
    }
}
