using System;
using System.Globalization;

namespace DollarToRealConverter 
{
    public class Menu 
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do dólar hoje: ");
            var dolarHoje = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor em dólar: ");
            var dolarValor = decimal.Parse(Console.ReadLine());

            Converter(dolarHoje, dolarValor);
        }

        public static void Converter(decimal dolarHoje, decimal dolarValor)
        {
            var real = dolarHoje * dolarValor;
            Console.WriteLine($"O valor de ${dolarValor} corresponde a {real.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");

        }
    }
}