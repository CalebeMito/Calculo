using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class soma_dos_numeros : Form
    {
        public soma_dos_numeros()
        {
            InitializeComponent();
        }

        private void soma_dos_numeros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, soma = 0, n;
            n = int.Parse(textBox1.Text);
            for (i = 0; i <= n; i++)
            {
                soma = soma + i;
            }
            label2.Text = "Soma dos "+ n +" :" + soma;
        }
    }
}
