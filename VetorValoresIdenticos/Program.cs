// Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes 
// que V1 e V2 possuem valores idênticos nas mesmas posições. 

using System;
using static System.Console;

namespace VetorValoresIdenticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            var r = new Random();
            var v1 = new int[50];
            var v2 = new int[50];

            for(var i = 0; i < v1.Length; i++)
            {
                v1[i] = r.Next(1, 10);
                v2[i] = r.Next(1, 10);

                if(v1[i] == v2[i])
                {
                    WriteLine($"Os vetores na posição {i}, possuem o mesmo valor: {v1[i]}");
                }
            }
        }
    }
}
