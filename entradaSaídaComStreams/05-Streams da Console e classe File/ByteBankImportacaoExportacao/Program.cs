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
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText.");

            //var bytesArquivo = File.ReadAllBytes("contas.txt");
            //Console.WriteLine(bytesArquivo.Length);

            //var linhas = File.ReadAllLines("contas.txt");
            //Console.WriteLine(linhas.Length);

            //foreach (var item in linhas)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Digite o seu nome:");
            //var nome = Console.ReadLine();

            //Console.WriteLine($"Seu nome é: {nome}");

            Console.WriteLine("Pronto. Tecle Enter para finalizar.");
            Console.ReadLine();
        }
        
        
    }
}
