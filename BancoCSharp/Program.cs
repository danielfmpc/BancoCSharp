using System;
using System.Globalization;

namespace BancoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco;
            double saldo;
            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            char verificaDeposito = char.Parse(Console.ReadLine());

            if (verificaDeposito == 's' || verificaDeposito == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                banco = new Banco(conta, nome, saldo);
            }
            else
            {
                banco = new Banco(conta, nome);
            }
            Console.WriteLine();

            Console.WriteLine(banco);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            saldo = double.Parse(Console.ReadLine());
            banco.Deposito(saldo);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(banco);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saldo = double.Parse(Console.ReadLine());
            banco.Saque(saldo);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(banco);

        }
    }
}
