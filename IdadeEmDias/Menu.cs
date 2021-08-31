using System;

namespace IdadeEmDias
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite a data atual: ");
            Console.WriteLine("Dia: ");
            var diaAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Mês: "); 
            var mesAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Ano: ");
            var anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Agora digite sua data de nascimento: ");

            Console.WriteLine("Dia: ");
            var diaNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Mês: ");
            var mesNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Ano: ");
            var anoNasc = int.Parse(Console.ReadLine());

            var idade = anoAtual - anoNasc;

            var idadeDias = (idade * 365) - ((mesNasc * 30) - (mesAtual * 30));

            Console.WriteLine($"A sua idade em dias é: {idadeDias}");
        }
    }
}