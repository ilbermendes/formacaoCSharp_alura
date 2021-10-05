using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 - Conversões e outros tipos numéricos");
            Console.WriteLine();

            double salario = 1250.50;
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //64 bit
            long  universo = 13000000000;
            Console.WriteLine(universo);

            //16 bit
            short valorPequeno = 10000;
            Console.WriteLine(valorPequeno);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
