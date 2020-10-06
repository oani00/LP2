using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * -Validar entradas
    * writetoleft
    * Mascara ao contrario
 */



namespace Imposto
{
    public partial class Form1 : Form
    {
        double INSS, IRPF, SalFamilia, SalLiquido, SalBruto;
        int Filhos;
        string Nome, aliqINSS, aliqIRPF;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////Esquece esse aqui, exclui////////////
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //variaveis declaradas no global

            //Trazendo os dados das caixas:
                Filhos = Convert.ToInt32(mskNumFilhos.Text);
                Nome = mskFuncionario.Text;
                SalBruto = Convert.ToDouble(mskSalBruto.Text);

                ////////////////////////VALIDE AQUI////////////////////////
                ////////////////////////VALIDE AQUI////////////////////////
                ////////////////////////VALIDE AQUI////////////////////////
                ////////////////////////VALIDE AQUI////////////////////////
            
            //-----------INSS-------------
            if (SalBruto <= 800.47) 
            { 
                aliqINSS = "7.65%";
                INSS = 0.0765 * SalBruto;
            }
            else if(800.47 < SalBruto && SalBruto <= 1050)
            {
                aliqINSS = "8.65%";
                INSS = 0.0865 * SalBruto;
            }
            else if(1050 < SalBruto && SalBruto <= 1400.77)
            {
                aliqINSS = "9.00%";
                INSS = 0.09 * SalBruto;
            }
            else if(1400.77 < SalBruto && SalBruto <= 2801.56)
            {
                aliqINSS = "11.00%";
                INSS = 0.11 * SalBruto;
            }
            else
            {
                aliqINSS = "fixo RS 308.17";
                INSS = 308.17;
            }

            //-----------IRPF-------------

            if (SalBruto <= 1257.12)
            {
                aliqIRPF = "0.00%";
                IRPF = 0 * SalBruto;
            }
            else if (1257.12 < SalBruto && SalBruto <= 2512.08)
            {
                aliqIRPF = "15.00%";
                IRPF = 0.15 * SalBruto;
            }
            else
            {
                aliqIRPF = "27.50%";
                IRPF = 0.275 * SalBruto;
            }

            //-----------SalFamilia-------------

            if (SalBruto <= 435.52)
            {
                SalFamilia = 22.33 * Filhos;
            }
            else if (435.52 < SalBruto && SalBruto <= 654.61)
            {
                SalFamilia = 15.74 * Filhos;
            }
            else
            {
                SalFamilia = 0;
            }

            //-----------SalLiquido-------------

            SalLiquido = SalBruto - INSS - IRPF + SalFamilia;

            //mostrando texto

            mskINSS.Text = aliqINSS;
            mskIRPF.Text = aliqIRPF;
            mskDescINSS.Text = INSS.ToString();
            mskDescIRPF.Text = IRPF.ToString(); 
            mskSalFamilia.Text = SalFamilia.ToString();  
            mskSalLiquido.Text = SalLiquido.ToString();    
            
            //Mensagem na label-----------------
                //https://www.youtube.com/watch?v=EiSxwg0UAjo
                //https://stackoverflow.com/questions/2131570/how-to-display-a-result-in-a-label-when-i-click-onto-a-button/2131607
                //https://stackoverflow.com/questions/2714977/visual-studio-add-a-line-break-in-a-label-via-the-designer

            string sr, solteiro;

            //------------SR.------------
            if (radFem.Checked == true)
                sr = "a Sra. ";
            else
                sr = "o Sr. ";

            //------------Solteiro------------
            if (checkBox1.Checked == true) //ou seja, é casado(a)
                solteiro = "casado";
            else
                solteiro = "solteiro(a)";

            //teste
            //MessageBox.Show("SALARIO:" + SalBruto); //teste
            //MessageBox.Show("NFILHOS:" + Filhos); //teste

            lblSaida.Text = "Os descontos do salário d" + sr + mskFuncionario.Text + "\n que é " + solteiro + " e que tem " + Convert.ToString(Filhos) + " filho(a)(s) são:";
           
        }

        private void mskFuncionario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //transformado em variavem no botão
        }

        private void mskSalBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //transformado em variavem no botão
        }

        private void mskNumFilhos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //A mensagem com os dados esta no button.
        }

        private void lblSaida_Click(object sender, EventArgs e)
        {
            //A mensagem com os dados esta no button.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
        }

        private void tstbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TESTE2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //by Luiz Miguel

            foreach (Control componente in this.Controls)
            {
                if (componente is TextBox)
                {
                    ((TextBox)componente).Clear();
                }
                else if (componente is MaskedTextBox)
                {
                    ((MaskedTextBox)componente).Clear();
                }
                else if (componente is ComboBox)
                {
                    ((ComboBox)componente).SelectedIndex = -1;
                }
                else if (componente is CheckBox)
                {
                    ((CheckBox)componente).Checked = false;
                }
                else if (componente is RadioButton)
                {
                    ((RadioButton)componente).Checked = false;
                }
                else if (componente is PictureBox)
                {
                    ((PictureBox)componente).Image = null;
                }
                else if (componente is RichTextBox)
                {
                    ((RichTextBox)componente).Clear();
                }
                else if (componente is ProgressBar)
                {
                    ((ProgressBar)componente).Value = ((ProgressBar)componente).Minimum;
                }
            }
        }
    }
}
