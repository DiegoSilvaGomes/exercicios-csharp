using System;

namespace Fibonacci
{
    class Menu
    {
        public static void Show()
        {
            //Console.Clear();
            Fibonacci();
        }

        public static void Fibonacci()
        {
            int num1=0, num2=1, aux;

            for (int i = 0; i​​​​​​​ < 60; i++)
            {
                aux=num1; 
                num1 = num2;
                num2 = num1 + aux; 
                Console.WriteLine("{0}", num2);

            }
        }
    }
}