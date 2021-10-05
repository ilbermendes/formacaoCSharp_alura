using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e Texto");
            Console.WriteLine();

            //char
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65; //código decimal ascii
            Console.WriteLine(primeiraLetra); // A

            primeiraLetra += (char)1; //é possível fazer operações matemáticas
            Console.WriteLine(primeiraLetra); // B

            //string
            string titulo = "Caracteres e Texto";
            Console.WriteLine(titulo);

            string lista = @"
- .NET
- Java
- Javascript";
            Console.WriteLine(lista);


            Console.ReadLine();
        }
    }
}
