using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variáveis");
            Console.WriteLine();
            int primeiroNumero = 10;
            int segundoNumero = 2;
            Console.WriteLine($"Valor do primeiro número: {primeiroNumero}.");
            Console.WriteLine($"Valor do segundo número: {segundoNumero}.");
            int soma = primeiroNumero + segundoNumero;
            Console.WriteLine($"A soma é = {soma}");
            int multiplicacao = primeiroNumero * segundoNumero;
            Console.WriteLine($"A multiplicação é = {multiplicacao}");

            Console.ReadLine();
        }
    }
}
