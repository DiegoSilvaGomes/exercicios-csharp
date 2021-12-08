using System;

namespace TesteTriangulo
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite o lado A do triângulo: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B do triângulo: ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C do triângulo: ");
            var c = int.Parse(Console.ReadLine());

            Verificacao(a, b, c);
        }

        public static void Verificacao(int a, int b, int c)
        {
            if(a < b+c && b < a+c && c < b+a)
            {
                if(a==b && b==c)
                    Console.WriteLine("Triângulo equilatero");
                else if(a==b || a==c || b==c)
                    Console.WriteLine("Triângulo isósceles");
                else
                    Console.WriteLine("Triângulo escaleno");                
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizaram um triângulo");
            }
        }
    }
}
