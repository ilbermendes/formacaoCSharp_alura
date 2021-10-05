using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // metodo 1
            //Cliente cliente1 = new Cliente();
            //cliente1.nome = "Maria";
            //cliente1.cpf = "123.456.789-10";
            //Console.WriteLine(cliente1.nome);

            //metodo 2

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = new Cliente();
            conta1.titular.nome = "Maria";
            conta1.titular.cpf = "123.456.789-10";

            Console.WriteLine(conta1.titular.nome);
            Console.WriteLine(conta1.titular.cpf);
            

            Console.ReadLine();
        }
    }
}
