using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente1 = new ContaCorrente();
            contaCorrente1.titular = "Gabriel";
            contaCorrente1.numeroAgencia = 101;
            contaCorrente1.numeroConta = 10101;
            contaCorrente1.saldo = 100;




            Console.WriteLine(contaCorrente.numeroConta);

            Console.ReadLine();
        }
    }
}
