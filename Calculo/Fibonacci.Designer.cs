﻿namespace Calculo
{
    partial class Fibonacci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 33);
            label1.TabIndex = 0;
            label1.Text = "FIBONACCI";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(453, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 42);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 2;
            label2.Text = "Informe o limite : ";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(557, 42);
            button1.Name = "button1";
            button1.Size = new Size(126, 28);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 82);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 104);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 141);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 221);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 162);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // Fibonacci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Fibonacci";
            Text = "Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label4;
    }
}