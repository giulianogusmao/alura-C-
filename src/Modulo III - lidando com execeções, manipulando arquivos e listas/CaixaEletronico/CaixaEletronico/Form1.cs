﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.Contas;
using CaixaEletronico.Usuarios;
using CaixaEletronico.Exceptions;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private List<Conta> contas = new List<Conta>();
        private static int qtdDeContas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = new Cliente();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Deposita(2200);
            this.AdicionaConta(contaDoVictor);

            Conta contaDoGuilherme = new ContaPoupanca();
            contaDoGuilherme.Titular = new Cliente();
            contaDoGuilherme.Titular.Nome = "Guilherme";
            contaDoGuilherme.Deposita(2900);
            this.AdicionaConta(contaDoGuilherme);

            Conta contaDoMauricio = new ContaInvestimento();
            contaDoMauricio.Titular = new Cliente();
            contaDoMauricio.Titular.Nome = "Mauricio";
            contaDoMauricio.Deposita(1800.85);
            this.AdicionaConta(contaDoMauricio);

            this.CalculaTotalRicos();
        }

        private void CalculaTotalRicos() {
            // exemplo LINQ e Lambda
            var filtradas = from c in contas
                            where c.Saldo > 2000
                            select c;

            saldoLinq.Text = "Total: " + filtradas.Sum(c => c.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoValorSaque = valorOperacao.Text;
            try
            {
                double valorDeposito = Convert.ToDouble(textoValorSaque);

                int indiceSelecionado = comboContas.SelectedIndex;

                Conta contaSelecionada = this.contas[indiceSelecionado];
                try
                {
                    contaSelecionada.Deposita(valorDeposito);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Valor de depósito é inválido");
                }

                this.MostraConta(contaSelecionada);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor de depósito é inválido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();
            this.RemoveConta(contaSelecionada);
        }

        private void RemoveConta(Conta conta)
        {
            this.contas.Remove(conta);
            comboContas.Items.Remove(conta);
            destinoDaTransferencia.Items.Remove(conta);
        }

        private void MostraConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente();
            c1.Deposita(200.0);
            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(125.0);
            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);

            MessageBox.Show("valor total: " + t.ValorTotal);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titularSelecionado = comboContas.Text;
            Conta contaSelecionada = this.BuscaContaSelecionada();
            this.MostraConta(contaSelecionada);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;

            Conta contaDestino = this.contas[indiceDaContaDestino];

            string textoValor = valorOperacao.Text;
            double valorTransferencia = Convert.ToDouble(textoValor);

            try
            {
                contaSelecionada.TransferePara(contaDestino, valorTransferencia);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor de transferência é inválido");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente para realizar a transferência");
            }

            this.MostraConta(contaSelecionada);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();

            ContaPoupanca cp = new ContaPoupanca();
            SeguroDeVida sv = new SeguroDeVida();

            gerenciador.Adiciona(cp);
            gerenciador.Adiciona(sv);

            MessageBox.Show("Total: " + gerenciador.Total);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContaCorrente c = new ContaCorrente();
            MessageBox.Show("A proxima conta corrente será de numero: " + c.ProximaConta());
        }

        public void AdicionaConta(Conta conta)
        {
            conta.Numero = 1 + qtdDeContas++;
            this.contas.Add(conta);
            comboContas.Items.Add(conta);
            destinoDaTransferencia.Items.Add(conta);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastro = new CadastroDeContas(this);
            cadastro.ShowDialog();
        }

        public int getQtdContas()
        {
            return this.contas.Count;
        }
    }
}