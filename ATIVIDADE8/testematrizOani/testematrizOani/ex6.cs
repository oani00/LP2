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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar matriz
            double[,] notas = new double[20, 3];

            //receber via inputbox
            //calcular media por aluno
            double media = 0;
            string nota = "";
            string auxiliar = "";

            for (var x = 0; x < 2; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (y + 1).ToString() + "do aluno" + (x + 1).ToString(), "Entrada de dados");

                    if (double.TryParse(auxiliar, out notas[x, y]))
                    {
                        media += (notas[x, y]) / 3;

                        //MessageBox.Show("a");
                        //nota = notas[x, y].ToString() + "\n" + nota;
                        //MessageBox.Show("b");
                        
                    }
                    else
                    {
                        MessageBox.Show("Número inválido");
                        y--;
                    }                  
                }
                
                nota = nota + "Aluno " + (x + 1).ToString() + ": " + media.ToString() + "\n";
                
                //a media precisa ser reiniciada
                media = 0;

            }

            //mostrar medias numa string
            MessageBox.Show(nota);
                        
        }
    }
}
