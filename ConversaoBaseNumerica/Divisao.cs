using System;

namespace ConversaoBaseNumerica
{
    public class Divisao
    {
        public static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            var resultado = n1 / n2;

            Console.WriteLine($"O resultado da divisão entre {n1} e {n2} é {resultado}.");

            Console.ReadKey();
            Menu.MenuSecundario();
        }
    }
}
