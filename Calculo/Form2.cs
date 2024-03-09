using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Na matemática, o fatorial de um número natural n, representado por n!, é o produto de todos os inteiros positivos menores ou iguais a n";
            
            int i, numero, fator;
            numero = int.Parse(textBox1.Text);
            fator = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                fator = fator * i;
            }

            label2.Text = "O fatorial do número é :" + fator;

        }
    }
}
