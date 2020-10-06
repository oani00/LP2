using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
                MessageBox.Show("Nome nao pode ser vazio!");
            else
                MessageBox.Show("O nome do aluno é:" + textBox1.Text);

            //COMMENTS AQUI
            //COMMENTS AQUI
            //COMMENTS AQUI

            if (checkBox1.CheckState == CheckState.Checked)
                MessageBox.Show("O aluno veio de outra Fatec!");
            else
                if (checkBox1.CheckState == CheckState.Unchecked)
                    MessageBox.Show("O aluno NAO veio de outra Fatec!");
                else
                    MessageBox.Show("Origem do aluno nao informada!");

            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Não escolheu o semestre");
            else
                MessageBox.Show(comboBox1.SelectedItem.ToString());

            if (radioButton1.Checked)
                MessageBox.Show("Periodo da manha");
            else
                MessageBox.Show("Periodo da noite");

            /*
             
            for (var x = 0; x < checkedListBox1.SelectedItems.Count; x++)
                MessageBox.Show("Selecionado:" + checkedListBox1.SelectedItems[x].ToString());

            for (var x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                MessageBox.Show("Checado:" + checkedListBox1.CheckedItems[x].ToString());

            */

            string stringona = "";

            for (var x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                stringona = stringona + "\n" + checkedListBox1.CheckedItems[x].ToString();

            MessageBox.Show(stringona);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 1; // setando para o primeiro no combobox
            listBox1.Items.Add("Sorocaba");
            listBox1.Items.Add("Votorantim");
            listBox1.Items.Add("Piedade");
            listBox1.Items.Add("SaltodPirapora");
            listBox1.Items.Add("Tatuir");
            listBox1.Items.Add("Pariqueraçu");
            listBox1.Items.Add("SanRoque");
            listBox1.Items.Add("PilardoSur");
            listBox1.Sorted = true;
            listBox1.SelectedIndex = 0; // Setando para o primeiro no listbox
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dtValida;
            if (DateTime.TryParse(maskedTextBox1.Text, out dtValida))
                MessageBox.Show("Data valida");
            else
                MessageBox.Show("Data Invalida");

            double vlValido;

            if (double.TryParse(maskedTextBox2.Text, out vlValido))
                MessageBox.Show("Valor valido:" + vlValido.ToString("N2"));
            else
                MessageBox.Show("Valor invalido");
        }


    }
}
