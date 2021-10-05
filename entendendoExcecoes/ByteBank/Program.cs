using System;
using ByteBank.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("Catch no método MAIN");
            }
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contasl.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha(); 
            //}
            //catch(IOException)
            //{ 
            //    Console.WriteLine("Exceção do tipo Entrada e Saída capturada e tratada.");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }            
            //}
        }

        private static void TestandoException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(101, 10101);
                conta1.Depositar(100);

                ContaCorrente conta2 = new ContaCorrente(101, 10102);
                conta2.Depositar(200);

                conta1.Transferir(200, conta2);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
