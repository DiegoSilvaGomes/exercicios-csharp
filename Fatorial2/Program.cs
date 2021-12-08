// 10 - Faça um algoritmo que receba um número e retorne o Fatorial desse número.


using System;

namespace Fatorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos números deseja saber o fatorial: ");
            var qtdNumeros = int.Parse(Console.ReadLine());

            for(int i = 0; i <= qtdNumeros; i++)
            {
                Console.Clear();
                var fatorial = 1;
                var aux = 2;

                Console.WriteLine("Informe o número: ");
                var numero = int.Parse(Console.ReadLine());

                for(i = 1; i < numero; i++)
                {
                    fatorial *= aux;
                    aux++;   
                }

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");     
            }
        }
    }
}
