using System;

namespace VerificacaoCodigo
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite o código para verificação: ");
            var codigo = int.Parse(Console.ReadLine());

            Options(codigo);
        }

        public static void Options(int codigo)
        {
            switch(codigo)
            {
                case 1: Console.WriteLine("Um"); break;
                case 2: Console.WriteLine("Dois"); break;
                case 3: Console.WriteLine("Três"); break;
                default: Console.WriteLine("Código inválido"); break;
            }
        }
    }
}