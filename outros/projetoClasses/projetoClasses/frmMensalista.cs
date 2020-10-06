﻿using System;
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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Mensalista objMensalista = new Mensalista();
            
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);


            MessageBox.Show("Nome:"+objMensalista.NomeEmpregado+"\n"+
                            "Matricula:"+objMensalista.Matricula+"\n"+
                            "Salario Mensal:"+objMensalista.SalarioMensal.ToString("N2")+"\n"+
                            "Data Entrada:"+objMensalista.DataEntradaEmpresa.ToString("dd/MM/yyyy")+"\n"+
                            "Salario Bruto:"+objMensalista.SalarioBruto()+"\n"+
                            "Tempo Trabalho:"+ objMensalista.TempoTrabalho());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtData.Text),
                Convert.ToDouble(txtSalario.Text));

            MessageBox.Show("Nome:" + objMensalista.NomeEmpregado + "\n" +
                            "Matricula:" + objMensalista.Matricula + "\n" +
                            "Salario Mensal:" + objMensalista.SalarioMensal.ToString("N2") + "\n" +
                            "Data Entrada:" + objMensalista.DataEntradaEmpresa.ToString("dd/MM/yyyy") + "\n" +
                            "Salario Bruto:" + objMensalista.SalarioBruto() + "\n" +
                            "Tempo Trabalho:" + objMensalista.TempoTrabalho());
        }
    }
}
