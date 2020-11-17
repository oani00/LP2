using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string stringona = "asssessoria";
            int comprimento = stringona.Length;
            int tot = 0;
            int contador = 0;
            do
            {
                if (Char.ToUpper(stringona[contador]) == 'S')
                tot += 1;

                contador += 1;
            }
                
            while (contador < comprimento) ;
            MessageBox.Show(tot.ToString());



        }

    }
}
