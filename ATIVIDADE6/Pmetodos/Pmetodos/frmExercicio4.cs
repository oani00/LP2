using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchTexto.Text.Length; i++)
                if (char.IsNumber(rchTexto.Text[i]))
                    contador += 1;

            MessageBox.Show("Quantidade de números:" + contador);
        }

        private void btnPosicaoBranco_Click(object sender, EventArgs e)
        {
            //um botão que localize o primeiro caracter branco e mostre a sua posição 
            //(usando isWhiteSpace e while)
                //https://docs.microsoft.com/pt-br/dotnet/api/system.char.iswhitespace?view=netcore-3.1
                //https://stackoverflow.com/questions/19478780/how-to-check-if-string-character-is-a-space
                // Baseado no codigo de Luiz Miguel

            int contador = 0, posicao = 0;
            
            while (!char.IsWhiteSpace (rchTexto.Text[contador]))
            {
                //Vai incrementando contador até que se chegue à posição do primeiro espaço.
                contador++;
            }
            
            posicao = contador;
            MessageBox.Show("posicao do primeiro espaco em branco: " + (posicao+1)) ; //pois posição começa em [0], aqui deve começar em 1.

        }

        private void btnContaLetras_Click(object sender, EventArgs e)
        {
            //um botão que mostre quantos caracteres alfabéticos existem dentro desse
            //componente (usando isLetter e foreach).

                //https://www.geeksforgeeks.org/c-sharp-char-isletter-method/

            char[] palavra = rchTexto.Text.ToCharArray();
            
            int contador = 0;
            foreach (char c in palavra)
            {
                if (Char.IsLetter(c) == true)
                    contador++;
            }

            rchTexto.Text = Convert.ToString(contador);
                
        }
    }
}