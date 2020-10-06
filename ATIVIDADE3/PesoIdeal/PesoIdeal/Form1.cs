using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double pesoinformado, pesoideal = 0, alturainformada;

            if (
                (
                    (double.TryParse(mskPesoAtual.Text, out pesoinformado))
                    &&
                    (double.TryParse(mskAltura.Text, out alturainformada))
                ) &&
                    (
                    rbtmFeminino.Checked | rbtmMasculino.Checked
                    )
                )
            {
                MessageBox.Show("A altura que você me disse foi:"+alturainformada);
                MessageBox.Show("E o peso:"+pesoinformado);
                
                if (rbtmFeminino.Checked)
                    pesoideal = Math.Round(62.1*alturainformada - 44.7);

                if (rbtmMasculino.Checked)
                    pesoideal = Math.Round(72.7 * alturainformada - 58);

                MessageBox.Show("O peso ideal é:" + pesoideal);

                if (pesoideal < pesoinformado)
                    MessageBox.Show("pesoideal < pesoinformado, logo Regime Obrigatório Já!");

                if (pesoideal == pesoinformado)
                    MessageBox.Show("pesoideal = pesoinformado, logo Você está com o peso ideal");

                if (pesoideal > pesoinformado)
                    MessageBox.Show("pesoideal > pesoinformado, logo Coma bastante massas e doces.");
            }else
                MessageBox.Show("Digite números por favor e selecione um sexo.");
            

        }
    }
}
