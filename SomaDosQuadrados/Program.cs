// Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos 
// ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.

using System;

namespace SomaDosQuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        public static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite um número positivo maior que 0 e menor que 10: ");
            var numero = int.Parse(Console.ReadLine());

            var soma = 0;

            if(numero <= 0 || numero >= 10)
            {
                Console.WriteLine("Número inválido!");
                Console.ReadKey();
                Soma();
            }
            else
            {
                for(var i = 0; i <= 20; i++)
                {
                    if(numero % 2 != 0)
                    {
                        soma += numero*numero;
                    }
                    numero++;                        
                }

                Console.WriteLine(soma);
            }
                
        }
    }
}
