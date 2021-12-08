// Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as 
// seguintes opções: 
// 1 – Adição 
// 2 – Subtração 
// 3 – Multiplicação 
// 4 – Divisão 
// Informe a opção: 
// A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o 
// programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao 
// menu principal. Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o 
// programa. 

using System;

namespace ConversaoBaseNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ExibeMenu();
        }
    }
}
