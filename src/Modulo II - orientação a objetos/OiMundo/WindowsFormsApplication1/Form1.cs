using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Conta conta1 = new Conta("Mauricio", 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta2 = new Conta("Guilherme", 200);

            conta1.Transferencia(200, conta2);
            conta1.imprimeSaldo();
            conta2.imprimeSaldo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta1.Deposita(1500.00);
            textoTitular.Text = conta1.Titular.Nome;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca("Exemplo poupanca", 1000);
            cp.Saca(100);
            cp.imprimeSaldo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta[] contas = new Conta[10];
            Conta c1 = new Conta("a", 10);
            Conta c2 = new Conta("b", 100);

            TotalizadorDeContas total = new TotalizadorDeContas();
            total.Adiciona(c1);
        }
    }
}
