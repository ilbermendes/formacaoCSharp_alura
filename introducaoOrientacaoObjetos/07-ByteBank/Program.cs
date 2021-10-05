using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente();
            contaCorrente1.Titular = new Cliente();
            contaCorrente1.Titular.Nome = "João";
            contaCorrente1.Titular.CPF = "123.456.789-10";
            contaCorrente1.NumeroAgencia = 101;
            contaCorrente1.NumeroConta = 10101;
            contaCorrente1.Saldo = 1000;

            Console.WriteLine(contaCorrente1.Titular.Nome);
            Console.WriteLine(contaCorrente1.Titular.CPF);
            Console.WriteLine(contaCorrente1.NumeroAgencia);
            Console.WriteLine(contaCorrente1.NumeroConta);
            Console.WriteLine(contaCorrente1.Saldo);
            

            Console.ReadLine();
        }
    }
}
