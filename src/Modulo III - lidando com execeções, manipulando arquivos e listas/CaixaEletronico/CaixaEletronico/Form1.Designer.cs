﻿namespace CaixaEletronico
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.valorOperacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.novaConta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.deletarConta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.saldoLinq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(166, 120);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(4);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(174, 22);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.Text = "Titular";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(166, 159);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(174, 22);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.Text = "Numero";
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(166, 198);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(174, 22);
            this.textoSaldo.TabIndex = 2;
            this.textoSaldo.Text = "Saldo";
            // 
            // valorOperacao
            // 
            this.valorOperacao.Location = new System.Drawing.Point(166, 254);
            this.valorOperacao.Margin = new System.Windows.Forms.Padding(4);
            this.valorOperacao.Name = "valorOperacao";
            this.valorOperacao.Size = new System.Drawing.Size(174, 22);
            this.valorOperacao.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Testa Totalizador De Contas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(166, 78);
            this.comboContas.Margin = new System.Windows.Forms.Padding(4);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(284, 24);
            this.comboContas.TabIndex = 7;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(166, 360);
            this.destinoDaTransferencia.Margin = new System.Windows.Forms.Padding(4);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(174, 24);
            this.destinoDaTransferencia.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 392);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Transferir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(458, 361);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(268, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "Testa Gerenciador De Imposto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(458, 397);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(268, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "Numero da proxima conta corrente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "N° Conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Titular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Selecione uma conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor:";
            // 
            // novaConta
            // 
            this.novaConta.Location = new System.Drawing.Point(166, 12);
            this.novaConta.Name = "novaConta";
            this.novaConta.Size = new System.Drawing.Size(142, 38);
            this.novaConta.TabIndex = 17;
            this.novaConta.Text = "Cadastrar Conta";
            this.novaConta.UseVisualStyleBackColor = true;
            this.novaConta.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Destinatario:";
            // 
            // deletarConta
            // 
            this.deletarConta.Location = new System.Drawing.Point(348, 117);
            this.deletarConta.Margin = new System.Windows.Forms.Padding(4);
            this.deletarConta.Name = "deletarConta";
            this.deletarConta.Size = new System.Drawing.Size(102, 28);
            this.deletarConta.TabIndex = 5;
            this.deletarConta.Text = "Deletar Conta";
            this.deletarConta.UseVisualStyleBackColor = true;
            this.deletarConta.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Saldo contas acima de 2.000,00:";
            // 
            // saldoLinq
            // 
            this.saldoLinq.Location = new System.Drawing.Point(458, 284);
            this.saldoLinq.Name = "saldoLinq";
            this.saldoLinq.Size = new System.Drawing.Size(268, 22);
            this.saldoLinq.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.saldoLinq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.novaConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deletarConta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorOperacao);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox valorOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button novaConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deletarConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox saldoLinq;
    }
}

