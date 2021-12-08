using System;

namespace NumerosImpares
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            for(var i = 100; i <= 200; i++)
            {
                if(i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}