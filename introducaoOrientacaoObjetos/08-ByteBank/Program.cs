using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(101, 10101);
            Console.WriteLine(contaCorrente1.NumeroAgencia);
            Console.WriteLine(contaCorrente1.NumeroConta);

            Console.ReadLine();
        }
    }
}
