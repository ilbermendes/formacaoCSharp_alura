using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ControleDeFluxoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Controle de Fluxo");
            Console.WriteLine();

            string nome = "Ilber";
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Número de letras: " + nome.Length);

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
            Console.WriteLine("Fim.");

            Console.ReadLine();
        }
    }
}
