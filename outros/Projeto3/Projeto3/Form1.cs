using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Componente ganhou o foco");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Componente perdeu o foco");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13) //se e enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; //para remover aquele som
            }
        }
    }
}
