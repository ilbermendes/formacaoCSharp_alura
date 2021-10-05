using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriada);

            ContaCorrente contaCorrente1 = new ContaCorrente(101, 10101);

            Console.WriteLine(ContaCorrente.TotalDeContasCriada);

            ContaCorrente contacorrente2 = new ContaCorrente(101, 10102);

            Console.WriteLine(ContaCorrente.TotalDeContasCriada);


            Console.ReadLine();
        }
    }
}
