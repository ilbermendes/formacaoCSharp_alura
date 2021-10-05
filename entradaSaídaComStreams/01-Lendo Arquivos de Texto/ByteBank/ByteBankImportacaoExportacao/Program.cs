using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            //                                 endereço              modo de operação 
            //                                    |                        |
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);//apenas abre

            var buffer = new byte[1024]; //1 kb - array de bytes que salva os dados

            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); //recebe a array de bytes, indice
                                                                           //inicial e indice final
                EscreverBuffer(buffer);
            }


            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            //var utf8 = new UTF8Encoding();
            var utf = Encoding.Default;

            var texto = utf.GetString(buffer);
            Console.Write(texto);

            //foreach (var item in buffer)
            //{
            //    Console.Write(item);
            //    Console.Write(" ");
            //}
        }
    }
} 
 