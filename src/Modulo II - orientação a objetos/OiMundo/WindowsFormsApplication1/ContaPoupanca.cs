using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(string NomeCliente, double Saldo) : base(NomeCliente, Saldo)
        {
        }

        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }
    }
}
