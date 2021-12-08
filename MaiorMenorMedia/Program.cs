//  Faça um programa que leia 10 valores inteiros e positivos e: 
// - Encontre o maior valor 
// - Encontre o menor valor 
// - Calcule a média dos números lidos 

using System;

namespace MaiorMenorMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite o 1º número: ");
            var numeroAtual = int.Parse(Console.ReadLine());

            var maior = numeroAtual;
            var menor = numeroAtual;

            var media = numeroAtual;

            for(var i = 2; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}º número: ");
                numeroAtual = int.Parse(Console.ReadLine());

                if(numeroAtual >= maior)
                    maior = numeroAtual;
                else if(numeroAtual <= menor)
                    menor = numeroAtual;

                media += numeroAtual;
            }

            media /= 10;
            Console.WriteLine($"maior {maior}, menor {menor} e a média é {media}");
        }
    }
}
