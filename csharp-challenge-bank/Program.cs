using csharp_challenge_bank.User;
using System;
using System.Globalization;

namespace csharp_challenge_bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número da conta: ");
            int numero = Console.Read();
            Console.WriteLine("Entre com o titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Entre com o número da conta: ");
            char resp = char.Parse(Console.ReadLine());
        }
    }
}
