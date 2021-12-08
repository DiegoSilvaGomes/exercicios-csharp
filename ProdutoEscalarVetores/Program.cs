//  Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar 
// a soma de todos dos resultados da multiplicação de x[i] por y[i]. 

using System;

namespace ProdutoEscalarVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de elementos que deseja incluir nos vetores x e y: ");
            var cont = int.Parse(Console.ReadLine());

            var x = new int[cont];
            var y = new int[cont];
            var soma = new int[1] {0};

            for(var i = 0; i < cont; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor de x: ");
                x[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o {i + 1}º valor de y: ");
                y[i] = int.Parse(Console.ReadLine());

                soma[0] += x[i] * y[i];
            }

            Console.WriteLine($"O produto escalar entre os vetores x e y é: {soma[0]}");

        }
    }
}
