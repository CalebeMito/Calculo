namespace Calculo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cALCULOSToolStripMenuItem = new ToolStripMenuItem();
            gerarSérieDeFibonacciToolStripMenuItem = new ToolStripMenuItem();
            gerarFatorialDeUmNúmeroToolStripMenuItem = new ToolStripMenuItem();
            gerarSomaDeNNúmerosToolStripMenuItem = new ToolStripMenuItem();
            obterOsFatoresDeUmNúmeroToolStripMenuItem = new ToolStripMenuItem();
            verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem = new ToolStripMenuItem();
            verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem = new ToolStripMenuItem();
            calcularOMDCEntreDoisNúmerosToolStripMenuItem = new ToolStripMenuItem();
            calcularOMMCEntreDoisNúmerosToolStripMenuItem = new ToolStripMenuItem();
            verificarSeUmNúmeroÉPrimoToolStripMenuItem = new ToolStripMenuItem();
            calcularARaizCúbicaDeUmNúmeroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cALCULOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cALCULOSToolStripMenuItem
            // 
            cALCULOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarSérieDeFibonacciToolStripMenuItem, gerarFatorialDeUmNúmeroToolStripMenuItem, gerarSomaDeNNúmerosToolStripMenuItem, obterOsFatoresDeUmNúmeroToolStripMenuItem, verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem, verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem, calcularOMDCEntreDoisNúmerosToolStripMenuItem, calcularOMMCEntreDoisNúmerosToolStripMenuItem, verificarSeUmNúmeroÉPrimoToolStripMenuItem, calcularARaizCúbicaDeUmNúmeroToolStripMenuItem });
            cALCULOSToolStripMenuItem.Name = "cALCULOSToolStripMenuItem";
            cALCULOSToolStripMenuItem.Size = new Size(92, 24);
            cALCULOSToolStripMenuItem.Text = "CALCULOS";
            // 
            // gerarSérieDeFibonacciToolStripMenuItem
            // 
            gerarSérieDeFibonacciToolStripMenuItem.Name = "gerarSérieDeFibonacciToolStripMenuItem";
            gerarSérieDeFibonacciToolStripMenuItem.Size = new Size(446, 26);
            gerarSérieDeFibonacciToolStripMenuItem.Text = "1. Gerar Série de Fibonacci";
            gerarSérieDeFibonacciToolStripMenuItem.Click += gerarSérieDeFibonacciToolStripMenuItem_Click;
            // 
            // gerarFatorialDeUmNúmeroToolStripMenuItem
            // 
            gerarFatorialDeUmNúmeroToolStripMenuItem.Name = "gerarFatorialDeUmNúmeroToolStripMenuItem";
            gerarFatorialDeUmNúmeroToolStripMenuItem.Size = new Size(446, 26);
            gerarFatorialDeUmNúmeroToolStripMenuItem.Text = "2. Gerar Fatorial de um Número";
            gerarFatorialDeUmNúmeroToolStripMenuItem.Click += gerarFatorialDeUmNúmeroToolStripMenuItem_Click;
            // 
            // gerarSomaDeNNúmerosToolStripMenuItem
            // 
            gerarSomaDeNNúmerosToolStripMenuItem.Name = "gerarSomaDeNNúmerosToolStripMenuItem";
            gerarSomaDeNNúmerosToolStripMenuItem.Size = new Size(446, 26);
            gerarSomaDeNNúmerosToolStripMenuItem.Text = "3. Gerar Soma de N Números";
            gerarSomaDeNNúmerosToolStripMenuItem.Click += gerarSomaDeNNúmerosToolStripMenuItem_Click;
            // 
            // obterOsFatoresDeUmNúmeroToolStripMenuItem
            // 
            obterOsFatoresDeUmNúmeroToolStripMenuItem.Name = "obterOsFatoresDeUmNúmeroToolStripMenuItem";
            obterOsFatoresDeUmNúmeroToolStripMenuItem.Size = new Size(446, 26);
            obterOsFatoresDeUmNúmeroToolStripMenuItem.Text = "4. Obter os fatores de um número";
            obterOsFatoresDeUmNúmeroToolStripMenuItem.Click += obterOsFatoresDeUmNúmeroToolStripMenuItem_Click;
            // 
            // verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem
            // 
            verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem.Name = "verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem";
            verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem.Size = new Size(446, 26);
            verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem.Text = "5. Verificar se um número é um número de Armstrong";
            verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem.Click += verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem_Click;
            // 
            // verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem
            // 
            verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem.Name = "verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem";
            verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem.Size = new Size(446, 26);
            verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem.Text = "6. Verificar se um número é um número Perfeito";
            verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem.Click += verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem_Click;
            // 
            // calcularOMDCEntreDoisNúmerosToolStripMenuItem
            // 
            calcularOMDCEntreDoisNúmerosToolStripMenuItem.Name = "calcularOMDCEntreDoisNúmerosToolStripMenuItem";
            calcularOMDCEntreDoisNúmerosToolStripMenuItem.Size = new Size(446, 26);
            calcularOMDCEntreDoisNúmerosToolStripMenuItem.Text = "7. Calcular o MDC entre dois números";
            calcularOMDCEntreDoisNúmerosToolStripMenuItem.Click += calcularOMDCEntreDoisNúmerosToolStripMenuItem_Click;
            // 
            // calcularOMMCEntreDoisNúmerosToolStripMenuItem
            // 
            calcularOMMCEntreDoisNúmerosToolStripMenuItem.Name = "calcularOMMCEntreDoisNúmerosToolStripMenuItem";
            calcularOMMCEntreDoisNúmerosToolStripMenuItem.Size = new Size(446, 26);
            calcularOMMCEntreDoisNúmerosToolStripMenuItem.Text = "8. Calcular o MMC entre dois números";
            calcularOMMCEntreDoisNúmerosToolStripMenuItem.Click += calcularOMMCEntreDoisNúmerosToolStripMenuItem_Click;
            // 
            // verificarSeUmNúmeroÉPrimoToolStripMenuItem
            // 
            verificarSeUmNúmeroÉPrimoToolStripMenuItem.Name = "verificarSeUmNúmeroÉPrimoToolStripMenuItem";
            verificarSeUmNúmeroÉPrimoToolStripMenuItem.Size = new Size(446, 26);
            verificarSeUmNúmeroÉPrimoToolStripMenuItem.Text = "9. Verificar se um número é Primo";
            verificarSeUmNúmeroÉPrimoToolStripMenuItem.Click += verificarSeUmNúmeroÉPrimoToolStripMenuItem_Click;
            // 
            // calcularARaizCúbicaDeUmNúmeroToolStripMenuItem
            // 
            calcularARaizCúbicaDeUmNúmeroToolStripMenuItem.Name = "calcularARaizCúbicaDeUmNúmeroToolStripMenuItem";
            calcularARaizCúbicaDeUmNúmeroToolStripMenuItem.Size = new Size(446, 26);
            calcularARaizCúbicaDeUmNúmeroToolStripMenuItem.Text = "10. Calcular a raiz cúbica de um número";
            calcularARaizCúbicaDeUmNúmeroToolStripMenuItem.Click += calcularARaizCúbicaDeUmNúmeroToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cALCULOSToolStripMenuItem;
        private ToolStripMenuItem gerarSérieDeFibonacciToolStripMenuItem;
        private ToolStripMenuItem gerarFatorialDeUmNúmeroToolStripMenuItem;
        private ToolStripMenuItem gerarSomaDeNNúmerosToolStripMenuItem;
        private ToolStripMenuItem obterOsFatoresDeUmNúmeroToolStripMenuItem;
        private ToolStripMenuItem verificarSeUmNúmeroÉUmNúmeroDeArmstrongToolStripMenuItem;
        private ToolStripMenuItem verificarSeUmNúmeroÉUmNúmeroPerfeitoToolStripMenuItem;
        private ToolStripMenuItem calcularOMDCEntreDoisNúmerosToolStripMenuItem;
        private ToolStripMenuItem calcularOMMCEntreDoisNúmerosToolStripMenuItem;
        private ToolStripMenuItem verificarSeUmNúmeroÉPrimoToolStripMenuItem;
        private ToolStripMenuItem calcularARaizCúbicaDeUmNúmeroToolStripMenuItem;
    }
}
