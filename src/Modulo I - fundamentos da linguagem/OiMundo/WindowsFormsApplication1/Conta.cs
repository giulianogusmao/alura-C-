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
        public int numero;
        public string titular;
        public double saldo;
        
        public void Saca(double valor) {
            this.saldo -= valor;
        }

        public void Deposita(double valor) {
            this.saldo += valor;
        }

        public void Transferencia(double valor, Conta Destino)
        {
            this.Saca(valor);
            Destino.Deposita(valor);
        }

        public void imprimeSaldo()
        {
            MessageBox.Show(this.titular + " - Saldo atual: " + this.saldo);
        }
    }
}
