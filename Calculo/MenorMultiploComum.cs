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
    public partial class MenorMultiploComum : Form
    {
        public MenorMultiploComum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, x, y, mmc = 0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            x = num1;
            y = num2;

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }

            mmc = (x * y) / num1;

            label4.Text = string.Format("O Menor múltiplo Comum entre {0} e {1} é {2}", x, y, mmc);

        }
    }
}
