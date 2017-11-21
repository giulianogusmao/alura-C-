using System;
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

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente titular = new Cliente();
            titular.Nome = titularConta.Text;

            int numero = this.aplicacaoPrincipal.getQtdContas() + 1;

            Conta conta;

            switch(Convert.ToString(tipoConta.SelectedItem))
            {
                case "Poupança":
                    conta = new ContaPoupanca() {
                        Numero = numero, Titular = titular
                    };
                    break;
                case "Investimento":
                    conta = new ContaInvestimento() {
                        Numero = numero, Titular = titular
                    };
                    break;
                default:
                    conta = new ContaCorrente() {
                        Numero = numero, Titular = titular
                    };
                    break;
            }

            this.aplicacaoPrincipal.AdicionaConta(conta);
            MessageBox.Show("Conta cadastrada com sucesso");
            this.Close();
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            tipoConta.Items.Add("Corrente");
            tipoConta.Items.Add("Poupança");
            tipoConta.Items.Add("Investimento");
        }
    }
}
