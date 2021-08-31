using System;

namespace TrocaValores
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            var a = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite o segundo número: ");
            var b = int.Parse(Console.ReadLine()); 

            var aNovo = 0;
            var bNovo = 0;

            if (a != b)
                aNovo = b;
            else
                aNovo = a;
            if (b != a)
                bNovo = a;
            else 
                bNovo = b;
                
            a = aNovo;
            b = bNovo;

            Console.WriteLine($"Os números digitados em ordem inversa são: {a} e {b} ");
        }
    }
}

