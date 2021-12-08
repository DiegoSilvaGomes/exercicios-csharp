using System;

namespace NumerosPositivos
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            InserirNumeros();
        }

        public static void InserirNumeros()
        {
            var numero = 0;
            var totalPar = 0;
            var totalImpar = 0;

            while(numero >= 0)
            {
                Console.WriteLine("Digite um número positivo. Caso o número seja negativo o programa será encerrado.");
                numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0 && numero >= 0)
                {
                    Console.WriteLine($"{numero} é um número par.");

                    totalPar += numero;
                }else if (numero >= 0){
                    Console.WriteLine($"{numero} é um número ímpar.");

                    totalImpar += numero;
                }
            }

            Console.WriteLine($"A soma dos números pares é: {totalPar}");
            Console.WriteLine($"A soma dos números ímpares é: {totalImpar}");
        }
    }
}

