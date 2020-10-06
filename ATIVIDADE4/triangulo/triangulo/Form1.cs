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
            double ladoA, ladoB, ladoC;

            if (( (double.TryParse(txtA.Text, out ladoA)) && (double.TryParse(txtB.Text, out ladoB))) 
                && (double.TryParse(txtC.Text, out ladoC)))
            {
                if (Math.Abs(ladoB - ladoC) < ladoA && ladoA < ladoB + ladoC &&
                    Math.Abs(ladoA - ladoC) < ladoB && ladoB < ladoA + ladoC &&
                    Math.Abs(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB)
                {
                    if (((ladoA == ladoB) | (ladoA == ladoC)) | (ladoB == ladoC)){
                    MessageBox.Show("É Isósceles! (2 lados iguais)");
                    }

                    if(ladoA == ladoB && ladoB == ladoC){
                    MessageBox.Show("É Equilátero! (3 lados iguais)");
                    }

                    if(ladoA != ladoB && ladoB != ladoC){
                    MessageBox.Show("É Escaleno! (nenhu lado igual)");
                    }
                }
            }else{
            MessageBox.Show("Insira 3 lados (afinal precisa ser um triangulo) e de lados positivos.");
            }

         }

    }
}
