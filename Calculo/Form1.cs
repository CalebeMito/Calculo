namespace Calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarSérieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Fibonacci = new Fibonacci();
            T_Fibonacci.Show();

        }

        private void gerarFatorialDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Fatorial = new Form2();
            T_Fatorial.Show();
        }

        private void gerarSomaDeNNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Soma_numeros = new soma_dos_numeros();
            T_Soma_numeros.Show();
        }

        private void obterOsFatoresDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Fatores = new Obter_Fatores();
            T_Fatores.Show();
        }

        private void verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Numero_Armstrong = new Numero_Armstrong();
            T_Numero_Armstrong.Show();
        }

        private void verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Verificar_Numero_Perfeito = new Verificar_Numero_Perfeito();
            T_Verificar_Numero_Perfeito.Show();
        }

        private void calcularOMDCEntreDoisNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_MaiorDivisorComum = new MaiorDivisorComum();
            T_MaiorDivisorComum.Show();
        }

        private void calcularOMMCEntreDoisNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_MenorMultiploComum = new MenorMultiploComum();
            T_MenorMultiploComum.Show();
        }

        private void verificarSeUmNúmeroÉPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_Eprimo = new Primo();
            T_Eprimo.Show();
        }

        private void calcularARaizCúbicaDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form T_RaizCubica = new RaizCubica();
            T_RaizCubica.Show();
        }
    }
}
