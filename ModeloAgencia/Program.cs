/*
Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha 
idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram 
inscritas 13 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em 
2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a 
concorrer a uma vaga para a campanha milionária. 
*/

using System;
using static System.Console;

namespace ModeloAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nome = {"Márcia", "Maria", "Kamille","Dafne","Angela", "Paula", "Bruna", "Britney", "Ligia", "Maisa", "Diana", "Anitta"};

            int[] idade = {26, 58, 18, 11, 20, 35, 19, 35, 30, 19, 20, 28};

            WriteLine("Modelos aptas a concorrer a vaga: ");
            for(var i = 0; i < idade.Length; i++)
            {
                if(idade[i] >= 18 && idade[i] <= 20)
                {
                    WriteLine(nome[i]);
                }
            }

        }
    }
}
