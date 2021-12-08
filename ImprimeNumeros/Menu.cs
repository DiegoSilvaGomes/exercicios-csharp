using System;

namespace ImprimeNumeros
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Numeros();
        }

        public static void Numeros()
        {
            for(var i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}