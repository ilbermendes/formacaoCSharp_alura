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
        static void UsandoStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fileStream = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fileStream))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    var msg = $"Agência: {contaCorrente.Agencia} - Número: {contaCorrente.Numero} - Titular: {contaCorrente.Titular.Nome} - Saldo: {contaCorrente.Saldo}.";
                    Console.WriteLine(msg);
                }
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(' ');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;


            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}