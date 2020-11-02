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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSalBruto_Click(object sender, EventArgs e)
        {
            /*A forma de cálculo do salário bruto dos funcionários de uma empresa é a seguinte:
            
            salário bruto=A+Ax(0,05xB+0,1xC+0,1xD)+Total de gratificações
            Onde:
                A=salário de acordo com o cargo (plano de carreira)
                B=Produção >=100 -> se sim B=1 caso contrário B=0
                C=Produção >=120 -> se sim C=1 caso contrário C=0
                D=Produção >=150 -> se sim D=1 caso contrário D=0

            Restrição: O maior Salário Bruto a ser pago é 7.000,00. Valor acima de 7.000,00 só poderá ser pago a
                funcionários com Produção>=150
                e que tenham gratificação.

            Calcule o Salário Bruto. Usando na lógica a instrução IF.*/

            
            double SalBruto, A, B, C, D, TotalGratificacoes;
            int producao;

            TotalGratificacoes = Convert.ToDouble(txtGratificacao.Text);
            producao = Convert.ToInt32(txtProducao.Text);
            A = Convert.ToDouble(txtSalario.Text);

            if (producao >= 150)
            {
                B = 1;
                C = 1;
                D = 1;
            }else if(producao >= 120)
            {
                B = 1;
                C = 1;
                D = 0;
            }else if(producao>= 100)
            {
                B = 1;
                C = 0;
                D = 0;
            }
            else
            {
                B = 0;
                C = 0;
                D = 0;
            }
                        
            TotalGratificacoes = Convert.ToDouble(txtGratificacao.Text);

            SalBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + TotalGratificacoes;

            txtSalBruto.Text = Convert.ToString(SalBruto);
            
        }
    }
}
