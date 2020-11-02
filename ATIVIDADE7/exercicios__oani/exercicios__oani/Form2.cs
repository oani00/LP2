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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Fazer um programa para gerar o número H. O número N será fornecido em um TextBox.
            //H = 1 + 1/2 +1/3+1/4+1/5+...+1/N, 
            //utilizar instruções For.

            double h = 0;
            int n;

            n = Convert.ToInt32(txtBoxN.Text) +1;

            for (int i = 1; i < n; i++)
            {
                h += (1.0 / Convert.ToDouble(i));
            }

            if(h == 0)
                txtBoxH.Text = "É, ai daria 1/0 né... o que não é definido.";
            else
                txtBoxH.Text = Convert.ToString(h);


            


            //if (n != 0)
            //{
            //    for (int i = 1; i < n; i++)
            //    {
            //        h += (1.0 / Convert.ToDouble(i));                  
                    
            //    }
                
            //    txtBoxH.Text = Convert.ToString(h);
            //}
            //else
            //    txtBoxH.Text = "É, ai daria 1/0 né... o que não é definido.";

            
        }
    }
}
