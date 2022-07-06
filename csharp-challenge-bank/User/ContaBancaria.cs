using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenge_bank.User
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; } = 0;

        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public ContaBancaria()
        {

        }

        public void Deposito(double quantia)
        {
           quantia += Saldo;
        }

        public void Saque(double quantia)
        {  
            quantia -= Saldo;
        }
    }
}
