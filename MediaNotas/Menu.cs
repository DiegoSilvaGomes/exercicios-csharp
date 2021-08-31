using System;

namespace MediaNotas
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Notas();
        }

        public static void Notas()
        {
            var total = 0;

            for(var i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Digite a {i}ª nota: ");
                var nota = int.Parse(Console.ReadLine());

                total += nota;
            }

            total /= 4;

            Media(total);
        }

        public static void Media(int total)
        {
            if(total >= 7)
               Console.WriteLine($"Parabéns você foi aprovado! Sua média total foi {total}");
            else
            {
                Console.WriteLine("Média abaixo de 7. Digite a nota de recuperação: ");
                var notaRecup = int.Parse(Console.ReadLine());

                var mediaRecup = (total + notaRecup)/2;

                if(mediaRecup >= 7)
                    Console.WriteLine($"Parabéns você foi aprovado! Sua média total foi {mediaRecup}");
                else 
                {
                    Console.WriteLine($"Você foi reprovado. Média final: {mediaRecup}");
                }
            }
        }
    }
}