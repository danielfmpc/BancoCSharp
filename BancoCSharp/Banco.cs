using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace BancoCSharp
{
    class Banco
    {
        private string _nome;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public Banco(int conta, string nome, double saldo) : this(conta, nome)
        {
            Deposito(saldo);
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double saldo)
        {
            Saldo -= saldo + 5;
        }
        public override string ToString()
        {
            return $"{Conta}, Titular: {Nome}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
