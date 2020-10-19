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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
                //https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp

            int inicio = 0, fim = 1;

            inicio = Convert.ToInt32(txt1.Text);
            fim = Convert.ToInt32(txt2.Text);
                        
            Random r = new Random();
            int rInt = r.Next(inicio, fim); //for ints

            rchResultado.Text = Convert.ToString(rInt);
        }
    }
}
