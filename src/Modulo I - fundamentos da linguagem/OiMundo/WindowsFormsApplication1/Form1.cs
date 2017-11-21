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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.numero = 1;
            conta1.titular = "Mauricio";
            conta1.saldo = 1500.00;

            Conta conta2 = new Conta();
            conta2.numero = 1;
            conta2.titular = "Guilherme";
            conta2.saldo = 0;

            conta1.Transferencia(500, conta2);
            conta1.imprimeSaldo();
            conta2.imprimeSaldo();
        }
    }
}
