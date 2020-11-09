using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace testematrizOani
{
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Janete");
            lista.Add("Otávio");
            lista.Remove("Otávio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Thais");

            foreach (string item in lista)
            {
                MessageBox.Show(item);
            }
        }
    }
}
