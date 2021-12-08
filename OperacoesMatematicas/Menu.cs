using System;

namespace OperacoesMatematicas
{
    public class Menu
    {
        public static void  Show()
        {
            Console.Clear();

            Console.WriteLine("Olá! Por favor, escolha uma das opções abaixo: ");
            Console.WriteLine("===================");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("===================");

            var option = short.Parse(Console.ReadLine());

            Options(option);
        }

        public static void Options(short option)
        {
            switch(option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Show(); break;
            }
        }

        public static void Soma()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            var res = n1 + n2;

            Console.WriteLine($"O resultado da soma entre {n1} e {n2} é: {res}");

            Console.ReadKey();
            Show();
        }

        public static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            var res = n1 - n2;

            Console.WriteLine($"O resultado da subtração entre {n1} e {n2} é: {res}");

            Console.ReadKey();
            Show();
        }

        public static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            var res = n1 * n2;

            Console.WriteLine($"O resultado da multiplicação entre {n1} e {n2} é: {res}");

            Console.ReadKey();
            Show();
        }

        public static void Divisao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            var res = n1 / n2;

            Console.WriteLine($"O resultado da divisão entre {n1} e {n2} é: {res}");

            Console.ReadKey();
            Show();
        }
    }
}


