using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de referência
            ContaCorrente conta1 = new ContaCorrente(); //'new' instancia um objeto
            conta1.titular = "Maria";
            conta1.numeroAgencia = 101;
            conta1.numeroConta = 10101;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Maria";
            conta2.numeroAgencia = 101;
            conta2.numeroConta = 10101;

            Console.WriteLine(conta1 == conta2); //False

            conta1 = conta2; // duas variaveis apontando para o mesmo objeto
            Console.WriteLine(conta1 == conta2); // True

            //tipo de valor
            int idade1 = 20;
            int idade2 = 20;
            Console.WriteLine(idade1 == idade2); //True



            Console.ReadLine();
        }
    }
}
