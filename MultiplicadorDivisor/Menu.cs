// Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada 
// variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido 
// multiplicado pelo maior e o maior valor dividido pelo menor. 


using System;

namespace MultiplicadorDivisor
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            var a = int.Parse(Console.ReadLine());

            if(a <= 0)
            {
                Console.WriteLine("Valor inválido, digite um número válido maior que 0: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o segundo número: ");
            var b = int.Parse(Console.ReadLine());

            if(b <= 0)
            {
                Console.WriteLine("Valor inválido, digite um número válido maior que 0: ");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o terceiro número: ");
            var c = int.Parse(Console.ReadLine());

            if(c < 0)
            {
                Console.WriteLine("Valor inválido, digite um número válido maior que 0: ");
                c = int.Parse(Console.ReadLine());
            }

            Calculo(a, b, c);
        }

        public static void Calculo(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                if(b > c)
                {
                    Console.WriteLine($"O menor valor multiplicado pelo maior é: {c * a} e o maior valor dividido pelo menor é {a / c}.");
                }else{
                    Console.WriteLine($"O menor valor multiplicado pelo maior é: {b * a} e o maior valor dividido pelo menor é {a / b}.");
                }
            }

            if(b > a && b > c)
            {
                if(a > c)
                {
                    Console.WriteLine($"O menor valor multiplicado pelo maior é: {c * b} e o maior valor dividido pelo menor é {b / c}.");
                }else{
                    Console.WriteLine($"O menor valor multiplicado pelo maior é: {a * b} e o maior valor dividido pelo menor é {b / a}.");
                }
            }

            if(c > a && c > b)
            {
                if(a > b)
                {
                    Console.WriteLine($"O menor valor multiplicado pelo maior é: {b * c} e o maior valor dividido pelo menor é {c / b}.");
                }else{
                    Console.WriteLine($"O menor valor multiplicado pelo maior é: {a * c} e o maior valor dividido pelo menor é {c / a}.");
                }
            }

        }
    }
}

