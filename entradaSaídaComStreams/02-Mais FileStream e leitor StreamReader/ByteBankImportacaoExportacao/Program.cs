using ByteBankImportacaoExportacao.Modelos;
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
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            using(var fileStream = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using(var leitor = new StreamReader(fileStream))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }

            Console.ReadLine();
        }
    }
} 
 