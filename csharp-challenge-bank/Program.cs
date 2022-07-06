using csharp_challenge_bank.User;
using System;
using System.Globalization;

namespace csharp_challenge_bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular: ");
            string titular = Console.ReadLine();
            Console.Write("Voce irá depositar um valor inicial? s/n ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.Write("Qaul a quantia?");
                double quantiaInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, quantiaInicial);
            }
            else 
            {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);



            Console.WriteLine("Entre com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

        }
    }
}
