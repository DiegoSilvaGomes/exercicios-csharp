using System;

namespace Tabuada
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            MenuTabuada();
        }

        public static void MenuTabuada()
        {
            Console.WriteLine("De qual número você deseja saber a tabuada?");
            var numero = int.Parse(Console.ReadLine());

            CalculoTabuada(numero);
        }

        public static void CalculoTabuada(int numero)
        {
            Console.Clear();

            Console.WriteLine($"A tabuada de {numero} é: ");

            for(var i = 0; i <= 10; i++)
            {
                var tabuada = numero * i;

                Console.WriteLine($"{numero} X {i} = {tabuada}");
            }
        }
    }
}