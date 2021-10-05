using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarAquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "101,101013,2140.33,Joao Silva";

                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
               
            }


        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv"; 

            using(var fileStream = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using(var escritor = new StreamWriter(fileStream))
            {
                escritor.Write("101,101033,450.50,Maria Pereira");

            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); // Despeja o buffer para o Stream!

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }

            }

        }
    }
}
