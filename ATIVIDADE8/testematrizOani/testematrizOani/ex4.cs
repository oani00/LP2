using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testematrizOani
{
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             
            Ao final do laço, podemos afirmar que Total vale:
                a) 51 b) 50 c)46 d) 48
             
             */

            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;

            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show(Convert.ToString(Total));

        }
    }
}
