using static System.Console;
using System;

namespace CalculoSalario
{
    public class Menu
    {
        public static void Show()
        {
            string cont = "";

            while(cont != "S")
            {
                WriteLine("Digite o seu código de funcionário: ");
                var c = int.Parse(ReadLine());

                WriteLine("Digite a quantidade de horas trabalhadas: ");
                var n = int.Parse(ReadLine());
                
                var e = 0;

                if(n > 50)
                {
                    e = n - 50;
                    n = 50;
                }

                var salarioExcedente = e * 20.00;
                var salarioTotal = (n * 10.00) + salarioExcedente;
                
                WriteLine($"O salário mensal total é R${salarioTotal}, desse total o salário excedente foi de {salarioExcedente}"); 

                WriteLine("Deseja encerrar o programa? 'S' para sair");
                cont = ReadLine().ToUpper();
            }
                    
        }
    }
}

//  Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um 
// operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 
// 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora 
// excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O 
// programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o 
// programa?". 