using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Horista objHorista = new Horista();

            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);

            MessageBox.Show("Nome:" + objHorista.NomeEmpregado + "\n" +
                            "Matricula:" + objHorista.Matricula + "\n" +
                            "Salário por hojra:" + objHorista.SalarioHora.ToString("N2") + "\n" +
                            "Número de horas:" + objHorista.NumeroHora + "\n" +
                            "Faltas:" + objHorista.DiasFalta + "\n" +
                            "Data Entrada:" + objHorista.DataEntradaEmpresa.ToString("dd/MM/yy") + "\n" +
                            "Salário Bruto:" + objHorista.SalarioBruto() + "\n" +
                            "Tempo Trabalho:" + objHorista.TempoTrabalho());

        }
    }
}
