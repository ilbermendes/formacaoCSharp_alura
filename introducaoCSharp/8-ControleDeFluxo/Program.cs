using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ControleDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Controle de Fluxo");
            Console.WriteLine();

            double valorInvestido = 10000;
            int contador = 1;
            int quantidadeDeMeses = 12;

            while (contador <= quantidadeDeMeses)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine(valorInvestido);
                contador++;
            }


            Console.ReadLine();
        }
    }
}
