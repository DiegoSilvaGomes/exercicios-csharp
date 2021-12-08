// Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o 
// número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
// fim dos dados. 

using System;

namespace MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {   
            var contador = 0;
            var maior = 0;
            var menor = 0;

            while(contador >= 0)
            {
                Console.WriteLine("Digite um número: (número negativo para sair):");
                var numero = int.Parse(Console.ReadLine());
                if(numero < 0)
                    contador--;

                maior = numero;
                menor = numero;

                Console.WriteLine("Digite outro número: (número negativo para sair)");
                numero = int.Parse(Console.ReadLine());
                if(numero < 0)
                    contador--;
                    
                if(numero >= maior)
                    maior = numero;
                else if(numero <= menor)
                    menor = numero;

                Console.WriteLine($"O maior número é {maior} e o menor número é {menor}");

            }

            
        }
    }
}
