using System;

namespace PesoIdeal
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
            Console.WriteLine("Informe seu sexo. Para masculino digite (M), para feminino digite (F)");
            var sexo = Console.ReadLine().ToUpper(); 

            Console.WriteLine("Agora informe a sua altura: ");
            var h = double.Parse(Console.ReadLine());

            Options(sexo, h);
        }

        public static void Options(string sexo, double h)
        {
            Console.Clear();

            switch(sexo)
            {
                case "M": Homem(h); break;
                case "F": Mulher(h); break;
            }
        }

        public static void Homem(double h)
        {
            var peso = (72.7 * h) - 58;

            Console.WriteLine($"O seu peso ideal é: {peso}Kg.");
        }

        public static void Mulher(double h)
        {
            var peso = (62.1 * h) - 44.7;

            Console.WriteLine($"O seu peso ideal é: {peso}Kg.");
        }
    }
}
