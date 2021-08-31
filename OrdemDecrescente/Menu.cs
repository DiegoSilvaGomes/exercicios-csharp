using System;

namespace OrdemDecrescente
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            var n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("A sequência em ordem decrescente é: ");

           Decrescente(n1, n2, n3); 
        }

        public static void Decrescente(int n1, int n2, int n3)
        {
            if(n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine(n1);
                if(n2 >= n3) 
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }else {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }

            if(n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine(n2);
                if(n1 >= n3) 
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }else {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
            }

            if(n3 >= n1 && n3 >= n2)
            {
                Console.WriteLine(n3);
                if(n1 >= n2) 
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }else {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }
            
        }
    }
}
