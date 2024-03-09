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
    public partial class MaiorDivisorComum : Form
    {
        public MaiorDivisorComum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int resto;
            while (num2 != 0)
            {
                resto = num1 % num2;
                num1 = num2;
                num2 = resto;
            }

            listBox1.Items.Add(num1.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
