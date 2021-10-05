﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
           {
               new ContaCorrente(101, 10104),
               new ContaCorrente(101, 10101),
               new ContaCorrente(101, 10103)
           };

            foreach (var item in contas)
            {
                Console.WriteLine($"Agência: {item.Agencia} - Número: {item.Numero}");
            }

            Console.WriteLine();

            contas.Sort();

            foreach (var item in contas)
            {
                Console.WriteLine($"Agência: {item.Agencia} - Número: {item.Numero}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            // método Sort com string
            var nomes = new List<string>()
            {
                "João",
                "Maria",
                "Ziraldo",
                "Ana",
                "Carlos"
            };

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine();
            nomes.Sort();

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine();

            //método Sort com inteiros
            var numeros = new List<int>();
            numeros.AdicionarVarios(15, 3, 5, 8, 1, 7, 11, 9);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();

            numeros.Sort();

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();

            //var nome = "Ilber";
            //Console.WriteLine(nome);
            //var conta1 = new ContaCorrente(101, 10101);
            //Console.WriteLine(conta1.Agencia);
        }

        static void TestandoListaCriada()
        {
            //passamos o argumento <int> que substituíra o T na ] classe genérica Lista.
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(21, 32, 36, 17, 33, 30);
            for (int i = 0; i < idades.Tamanho; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void TestaListaDeObject()
        {

            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.AdicionarVarios(10, 5, 4, 16, 23, "um texto aqui no meio", 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine(idade);
            }
        }

        static void TestaLista()
        {
            ListaContaCorrente lista = new ListaContaCorrente();

            lista.AdicionarVarios(
                new ContaCorrente(101, 101001),
                new ContaCorrente(101, 101002),
                new ContaCorrente(101, 101003)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i}: {itemAtual.Agencia}/{itemAtual.Numero}");
            }
        }

        static int Somatorio(params int[] numeros) 
        {
            int somatorio = 0;
            foreach(int item in numeros)
            {
                somatorio += item; 
            }
            return somatorio;
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
