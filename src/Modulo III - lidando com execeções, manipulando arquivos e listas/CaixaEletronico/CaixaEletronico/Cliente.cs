﻿namespace CaixaEletronico.Usuarios
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;
        private bool EEmancipado;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.idade >= 18;
                var emancipado = (this.EEmancipado);
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente)obj;
            return this.rg.Equals(cliente.rg) || this.cpf.Equals(cliente.cpf);
        }

        public override string ToString()
        {
            return "Cliente Nome: " + this.Nome;
        }
    }
}