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
    public partial class Obter_Fatores : Form
    {
        public Obter_Fatores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0, x = 0;
            
            num = int.Parse(textBox1.Text);
            
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    listBox1.Items.Add(x.ToString()) ;
                }
            }

        }
    }
}
