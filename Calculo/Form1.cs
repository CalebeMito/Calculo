namespace Calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarS�rieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Fibonacci = new Fibonacci();
            T_Fibonacci.Show();

        }

        private void gerarFatorialDeUmN�meroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Fatorial = new Form2();
            T_Fatorial.Show();
        }

        private void gerarSomaDeNN�merosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Soma_numeros = new soma_dos_numeros();
            T_Soma_numeros.Show();
        }

        private void obterOsFatoresDeUmN�meroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Fatores = new Obter_Fatores();
            T_Fatores.Show();
        }

        private void verificarSeUmN�mero�UmN�meroDeArmstrongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Numero_Armstrong = new Numero_Armstrong();
            T_Numero_Armstrong.Show();
        }

        private void verificarSeUmN�mero�UmN�meroPerfeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Verificar_Numero_Perfeito = new Verificar_Numero_Perfeito();
            T_Verificar_Numero_Perfeito.Show();
        }

        private void calcularOMDCEntreDoisN�merosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_MaiorDivisorComum = new MaiorDivisorComum();
            T_MaiorDivisorComum.Show();
        }

        private void calcularOMMCEntreDoisN�merosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_MenorMultiploComum = new MenorMultiploComum();
            T_MenorMultiploComum.Show();
        }

        private void verificarSeUmN�mero�PrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Eprimo = new Primo();
            T_Eprimo.Show();
        }

        private void calcularARaizC�bicaDeUmN�meroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_RaizCubica = new RaizCubica();
            T_RaizCubica.Show();
        }
    }
}
