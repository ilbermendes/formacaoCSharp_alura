using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(101, 10102);
            Console.Write(conta1.Saldo);
            conta1.Sacar(-10);
            Console.ReadLine();
            
        }
    }
}
