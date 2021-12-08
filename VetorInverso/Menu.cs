using System;
using System.Linq;

namespace VetorInverso
{
    public class Menu
    {
        public static void Show()
        {

            Console.WriteLine("Digite a quantidade de valores que deseja incluir no vetor");
            var contador = int.Parse(Console.ReadLine());

            var vetor = new int[contador];

            for(var i = 0; i < contador; i++)
            {
                Console.WriteLine("Digite o número que deseja adicionar");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sequência na ordem de digitação: ");

            foreach(var item in vetor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sequência na ordem inversa: ");

            var vetorInverso = vetor.Reverse();

            foreach(var item in vetorInverso)
            {
                Console.WriteLine(item);
            }
        }

    }
}
