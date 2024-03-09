using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculo
{
    public partial class Verificar_Numero_Perfeito : Form
    {
        public Verificar_Numero_Perfeito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Um número perfeito é um número inteiro para o qual a soma de todos os seus, divisores positivos próprios (excluindo ele mesmo) é igual ao próprio número. Ex: 6 é um número perfeito, pois 1 + 2 + 3 = 6 ";

            int numero, soma = 0, n;

            numero = int.Parse(textBox2.Text);
            n = numero;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    soma = soma + i;
                }
            }
            if (soma == n)
            {
               
                label2.Text = "RESULTADO : O número informado É um número perfeito";
            }
            else
            {

                label2.Text = "RESULTADO :O número informado NÂO É um número perfeito";

            }
        }
    }
}
