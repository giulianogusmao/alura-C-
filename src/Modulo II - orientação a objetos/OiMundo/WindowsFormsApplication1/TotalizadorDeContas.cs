using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TotalizadorDeContas
    {
        public double Total { get; private set; }
        public void Adiciona(Conta conta)
        {
            this.Total += conta.Saldo;
        }
    }
}
