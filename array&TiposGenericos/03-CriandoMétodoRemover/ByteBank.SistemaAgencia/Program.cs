using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContaCorrente lista = new ListaContaCorrente();

            lista.Adicionar(new ContaCorrente(101, 101001));
            lista.Adicionar(new ContaCorrente(101, 101002));
            lista.Adicionar(new ContaCorrente(101, 101003));
            lista.Adicionar(new ContaCorrente(101, 101004));
            lista.Adicionar(new ContaCorrente(101, 101005));
            lista.Adicionar(new ContaCorrente(101, 101006));
            lista.Adicionar(new ContaCorrente(101, 101007));
            lista.Adicionar(new ContaCorrente(101, 101008));

            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contasCorrente = new ContaCorrente[]
            {
                new ContaCorrente(101, 101001),
                new ContaCorrente(101, 101002),
                new ContaCorrente(101, 101003)
            };

            for (int i = 0; i < contasCorrente.Length; i++)
            {
                ContaCorrente contaAtual = contasCorrente[i];
                Console.WriteLine($"Conta no Índice {i}: Agência: {contaAtual.Agencia}; Conta: {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            //Array de inteiros com 5 posições.
            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int totalSoma = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine($"Índice {i} = {idades[i]}");
                totalSoma += idades[i];
            }

            int media = totalSoma / idades.Length;

            Console.WriteLine($"Somatório de todos os índices da array: {totalSoma}");
            Console.WriteLine($"Média dos valores: {media}");
        }
    }
}
