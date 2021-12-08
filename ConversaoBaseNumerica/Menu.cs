using System;

namespace ConversaoBaseNumerica
{
    public class Menu
    {
        public static void ExibeMenu()
        {
            Console.Clear();

            Console.WriteLine("Digite o número da opção desejada:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1 – Adição");
            Console.WriteLine("2 – Subtração");
            Console.WriteLine("3 – Multiplicação");
            Console.WriteLine("4 – Divisão");
            Console.WriteLine("----------------------------------");

            var opcao = short.Parse(Console.ReadLine());
            Opcoes(opcao);
            Console.ReadKey();
        }

        public static void Opcoes(short opcao)
        {
            switch(opcao)
            {
                case 1: Adicao.Somar(); break;
                case 2: Subtracao.Subtrair(); break;
                case 3: Multiplicacao.Multiplicar(); break;
                case 4: Divisao.Dividir(); break;
                default: ExibeMenu(); break;
            }
        }

        public static void MenuSecundario()
        {
            Console.WriteLine("Caso deseje voltar ao menu principal digite 'S', ou digite outra tecla para sair.");

            var res = char.Parse(Console.ReadLine().ToUpper());

            switch(res)
            {
                case 'S': ExibeMenu(); break;
                default: Environment.Exit(0); break;
            }
        }
    }
}

