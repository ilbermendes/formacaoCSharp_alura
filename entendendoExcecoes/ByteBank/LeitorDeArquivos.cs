using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos (string arquivo)
        {
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            throw new IOException();
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
