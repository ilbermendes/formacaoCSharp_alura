using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_VariavelBooleana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Variável Booleana");
            Console.WriteLine();

            int idade = 17;
            bool estaAcompanhado = true;
            bool possuiTicket = true;
            bool possuiID = true;

            if (idade >= 18 || estaAcompanhado)
            {
                if (possuiTicket && possuiID)
                {
                    Console.WriteLine($"Idade: {idade}");
                    Console.WriteLine($"Acompanhado: {estaAcompanhado}");
                    Console.WriteLine($"Possui ticket? {possuiTicket}. Possui ID? {possuiID}");
                    Console.WriteLine("Pode entrar.");
                } else
                {
                    Console.WriteLine($"Idade: {idade}");
                    Console.WriteLine($"Acompanhado: {estaAcompanhado}");
                    Console.WriteLine($"Possui ticket? {possuiTicket}. Possui ID? {possuiID}");
                    Console.WriteLine("Não pode entrar.");
                }
                
            } else
            {
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine($"Acompanhado: {estaAcompanhado}");
                Console.WriteLine($"Possui ticket? {possuiTicket}. Possui ID? {possuiID}");
                Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
