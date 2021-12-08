//  Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta 
// ordem. O vetor terá no máximo 100 posições.

using System;
using System.Collections.Generic;

namespace VetorUmTresQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerosPositivos = new int[100];
            var numSorteado = new Random();
            List<int> n1 = new();
            List<int> n3 = new();
            List<int> n4 = new();

            for (var i = 0; i < numerosPositivos.Length; i++)
            {
                numerosPositivos[i] = numSorteado.Next(1, 100);
            }

            for (var i = 0; i < numerosPositivos.Length; i++)
            {
                if(numerosPositivos[i] == 1)
                    n1.Add(numerosPositivos[i]);
                if(numerosPositivos[i] == 3)
                    n3.Add(numerosPositivos[i]);
                if(numerosPositivos[i] == 4)
                    n4.Add(numerosPositivos[i]);   
            }

            Console.WriteLine($"Número de vezes que o número 1 aparece no vetor: {n1.Count}");
            Console.WriteLine($"Número de vezes que o número 3 aparece no vetor: {n3.Count}");
            Console.WriteLine($"Número de vezes que o número 4 aparece no vetor: {n4.Count}");
        }
    }
}
