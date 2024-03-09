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
    public partial class Numero_Armstrong : Form
    {
        public Numero_Armstrong()
        {
            InitializeComponent();
        }

        private void Numero_Armstrong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int numero, Resto, soma = 0;
            
            numero = int.Parse(textBox1.Text);

            for (int i = numero; i > 0; i = i / 10)
            {
                Resto = i % 10;
                soma = soma + Resto * Resto * Resto;
            }
            if (soma == numero)
            {
                
                label2.Text = "RESULTADO : O número informado É um número de Armstrong";
            }
            else
                label2.Text = "RESULTADO : O número informado NÃO É um número de Armstrong";

            textBox2.Text = "É um número de n dígitos que é igual a soma de cada, um dos seus dígitos elevado a n-ésima potência;  Ex: 153 (n= 3 dígitos) => 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153";

        }
    }
}
