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
    public partial class RaizCubica : Form
    {
        public RaizCubica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double res = Math.Pow(num, 1.0 / 3.0);

            label3.Text = string.Format("A raiz cúbica de {0} é igual a {1}", num, res);

        }
    }
}
