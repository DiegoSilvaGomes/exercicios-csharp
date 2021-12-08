// Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo 
// e maior que zero. Faça um programa para: 
// a. ler pelo teclado o vetor; 
// b. ler pelo teclado o número X; 
// c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X. 

using System;
using System.Collections.Generic;
using static System.Console;

namespace ComparaVetorInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            int[] vetor = { 1, 55, 53, 474, 8, 76, 7, 8, 9, 10 };
            var x = 8;
            var vetorMaior = new List<int>();
            var vetorMenor = new List<int>();
            var vetorIgual = new List<int>();

            WriteLine("O vetor: ");

            for (var i = 0; i < vetor.Length; i++)
            {

                Write($"{vetor[i]} | ");
            }
            
            WriteLine();
            WriteLine($"O Número: {x}");

            for (var i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > x)
                {
                    vetorMaior.Add(vetor[i]);
                }

                if (vetor[i] < x)
                {
                    vetorMenor.Add(vetor[i]);
                }

                if (vetor[i] == x)
                {
                    vetorIgual.Add(vetor[i]);
                }
                
            }

            WriteLine($"Existem {vetorMaior.Count} números maiores que {x}");
            WriteLine($"Existem {vetorMenor.Count} números menores que {x}");
            WriteLine($"Existem {vetorIgual.Count} números iguais a {x}");
            
        }
    }
}
