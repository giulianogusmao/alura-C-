using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Conta
    {
        public Cliente Titular { get; protected set; }
        public double Saldo { get; protected set; } = 0;
        
        public Conta(string NomeCliente, double Saldo)
        {
            this.Saldo = Saldo;
            this.Titular = new Cliente(NomeCliente);
        }
                
        public virtual void Saca(double valor) {
            this.Saldo -= valor;
        }

        public void Deposita(double valor) {
            this.Saldo += valor;
        }

        public void Transferencia(double valor, Conta Destino)
        {
            this.Saca(valor);
            Destino.Deposita(valor);
        }

        public void imprimeSaldo()
        {
            MessageBox.Show(this.Titular.Nome + " - Saldo atual: " + this.Saldo);
        }
    }
}
