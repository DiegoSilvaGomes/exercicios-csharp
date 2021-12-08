using System;

namespace VerificacaoNumeros
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            MenuOptions();          
        }

        public static void MenuOptions()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());  

            Console.WriteLine("=================================================================");

            Console.WriteLine("Escolhe uma das opções abaixo");
            Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro ");
            Console.WriteLine("2 – Verificar se os dois números lidos são pares ");
            Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("=================================================================");

            var option = short.Parse(Console.ReadLine());

            Options(n1, n2, option);
        }

        public static void Options(int n1, int n2, short option)
        {
            switch(option)
            {
                case 1: Multiplos(n1, n2); break;
                case 2: Pares(n1, n2); break;
                case 3: Media(n1, n2); break;
                case 4: Environment.Exit(0); break;
                default: Show(); break;
            }
        }

        public static void Multiplos(int n1, int n2)
        {
            if(n1 % n2 == 0)
                Console.WriteLine($"{n1} é múltiplo de {n2}");
                else
                    Console.WriteLine($"{n1} não é multiplo de {n2}");

            Console.ReadKey();
        }

        public static void Pares(int n1, int n2)
        {
            if(n1 % 2 == 0)
                Console.WriteLine($"{n1} é par");
                else 
                    Console.WriteLine($"{n1} não é par");

            if(n2 % 2 == 0)
                Console.WriteLine($"{n2} é par");
                else 
                    Console.WriteLine($"{n2} não é par");

            Console.ReadKey();
        }   

        public static void Media(int n1, int n2)
        {
            var media = (n1 + n2)/2;

            if(media >= 7)
                Console.WriteLine($"Média maior ou igual a 7. Média = {media}");
                else
                    Console.WriteLine($"Média menor que 7. Média = {media}");

            Console.ReadKey();
        }
    }
}

