//  Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número sorteado) tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número
// sorteado é maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de 
// tentativas feitas. 

using System;
using System.Collections.Generic;
using static System.Console;

namespace SorteioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            var numRandom = new Random();
            var numeroAleatorio = numRandom.Next(0, 100);
            var numeroUsuario = 0;
            var contador = 0;
            var aux = true;

            while(aux)
            {
                WriteLine("Digite um número");
                numeroUsuario = int.Parse(ReadLine());
                contador++;

                if(numeroAleatorio > numeroUsuario)
                    WriteLine("Número sorteado é maior que o número digitado!");
                if(numeroAleatorio < numeroUsuario)
                    WriteLine("Número sorteado é menor que o número digitado!");
                if(numeroAleatorio == numeroUsuario)
                {
                    WriteLine($"Você acertou o número! Número de tentativas: {contador}");
                    aux = false;
                }         
            }
                 
        } 
    }
}
