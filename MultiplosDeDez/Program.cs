// Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10". 

using System;

namespace MultiplosDeDez
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            
            
            for(int i = 1; i <= 100; i++)
            {
                if(i % 10 != 0)
                    Console.WriteLine(i);
                if(i % 10 == 0)
                    Console.WriteLine($"{i} - Múltiplo de 10");
            }
        }
    }
}
