using System;

namespace Fatorial 
{
    public class Menu
    {
        public static void Show()
        {
            //Console.Clear();

            Console.WriteLine("Informe a quantidade de números que deseja saber o fatorial: ");
            var numeros = int.Parse(Console.ReadLine());

            for(var i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Informe o número: ");
                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"O fatorial de {num} é: ");

                if(num < 0)
                    Console.WriteLine("Número negativo! Operação inválida!!!");
                    else if(num == 0)
                        Console.WriteLine("Por definição 0! = 1");
                        else if(num == 1)
                            Console.WriteLine("Por definição 1! = 1");
                            else
                            {
                                var aux = num;

                                for(var index = num; index >= 1; index--)
                                {
                                    num = num * (aux -1);
                                    aux--;

                                    if(aux == 1)
                                    {
                                        Console.WriteLine(num);
                                    }
                                }
                            }
            }
        }
    }
}


//  Escreva um programa que leia: 
// - a quantidade de números que deverá processar; 
// - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial. 
// Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N 