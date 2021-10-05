using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "José";
            Console.WriteLine(conta1.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Maria";

            Console.WriteLine("Sacando...");
            conta1.Sacar(50);

            Console.WriteLine(conta1.saldo);

            Console.WriteLine("Depositando..."); 
            conta1.Depositar(1000);

            Console.WriteLine(conta1.saldo);

            conta1.Transferir(500, conta2);
            Console.WriteLine("Transferindo da conta 1 para a conta 2");
            Console.WriteLine($"Saldo da conta1: {conta1.saldo}");
            Console.WriteLine($"Saldo da conta2: {conta2.saldo}");


            

            Console.ReadLine();
        }
    }
}
