using System;

namespace Combustivel
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Vamos calcular o combustivel gasto durante a sua viagem. Por favor, informe os dados abaixo: ");

            Console.WriteLine("O tempo gasto na viagem: ");
            var tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("A velocidade média: ");
            var velocidade = double.Parse(Console.ReadLine());

            Calculo(tempo, velocidade);

        }

        public static void Calculo(double tempo, double velocidade)
        {
            var distancia = tempo * velocidade;

            var litros_usados = distancia / 12;

            Console.WriteLine("Dados: ");
            Console.WriteLine($"Velocidade média: {velocidade}Km/h ");
            Console.WriteLine($"Tempo gasto: {tempo} horas");
            Console.WriteLine($"Distância percorrida: {distancia} Km");
            Console.WriteLine($"A quantidade de litros de combustivel utilizada foi de: {litros_usados} litros");
        }

    }
}