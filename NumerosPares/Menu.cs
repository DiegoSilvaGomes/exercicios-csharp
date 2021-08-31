using System;

namespace NumerosPares
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var num2 = int.Parse(Console.ReadLine());

            MaiorMenor(num1, num2);
        }

        public static void MaiorMenor(int num1, int num2)
        {
            if (num1 == num2)
                Pares(num1, num2);
            else if (num1 > num2)
            {
                var contador = num2;
                var maiorNum = num1;
                Pares(contador, maiorNum);
            }
            else{
                var contador = num1;
                var maiorNum = num2;
                Pares(contador, maiorNum);
            }

        }

        public static void Pares(int contador, int maiorNum)
        {

            Console.WriteLine("Os números pares entre os dois números digitados são: ");

            for(var cont = contador; cont <= maiorNum; cont++)
            {
                if (cont % 2 == 0){
                    Console.WriteLine($"{cont}");
                }
            }
        }
    }
}