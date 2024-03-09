using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculo
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ("Na matemática, a sucessão de Fibonacci," +
               Environment.NewLine + "é uma sequência de números inteiros, " +
               Environment.NewLine + "começando normalmente por 0 e 1, na qual cada termo subsequente " +
               Environment.NewLine + "corresponde à soma dos dois anteriores.");

            int contador = 0;
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;

            contador = int.Parse(textBox1.Text);

            label5.Text = f1.ToString();
            label6.Text = f2.ToString();

            for (int i = 0; i <= contador; i++)
            {
                f3 = f1 + f2;
                label4.Text = f3.ToString();
                f1 = f2;
                f2 = (int)f3;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
