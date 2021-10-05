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
    }
}
