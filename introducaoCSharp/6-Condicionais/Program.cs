using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Condicionais");
            Console.WriteLine();

            int idade = 18;
            if (idade < 18)
            {
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine("Menor de idade");
            } else
            {
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine("Maior de idade");
            }


            Console.ReadLine();
        }
    }
}
