using System;

namespace OrdemDecrescente
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
            for(var i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}