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
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            RA: _oani_0030482011028
            8 pessoas 
            
             Com ajuda de Luiz Miguel
             */

            int chars = 0;
            string[] nomes = new string[8];
            int[] tamanho = new int[8] ;
            string saida = "";
            
            for (var i = 0; i < 8; i++)
            {

                nomes[i] = Interaction.InputBox("Diga o nome do individuo " + (i + 1).ToString(), "Entrada de dados");
                //precisa ser reiniciada a cada loop
                chars = 0;
                foreach (char caracter in nomes[i])
                {
                    chars++;
                    if (char.IsWhiteSpace(caracter))
                        chars--;                    
                }

                tamanho[i] = chars;
                
                saida = saida + nomes[i] + " tem " + tamanho[i].ToString() + " caracteres" + "\n";

            }

            //mostrar dados
            richTextBox1.Text = saida;

        }
    }
}
