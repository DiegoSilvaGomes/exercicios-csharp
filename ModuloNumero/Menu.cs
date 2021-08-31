using System;

namespace ModuloNumero
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite um número positivo ou negativo: ");
            var num = int.Parse(Console.ReadLine());

            if (num >= 0)
                Console.WriteLine($"O módulo de {num} é {num}");
            else 
            {
                num = num * (-1);
                Console.WriteLine($"O módulo do número digitado é: {num}");
            }
                
        }
    }
}