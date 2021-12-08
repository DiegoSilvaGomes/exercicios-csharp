// Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de 
// alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.


using System;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula = 1;
            int media = 0;
            int cont = 0;
            int nota = 0;
            int soma = 0;

            while(matricula > 0)
            {
                Console.Clear();

                Console.WriteLine("Digite o número da matrícula do aluno: ");
                Console.WriteLine("Obs: caso tenha finalizado digite 0");
                matricula = int.Parse(Console.ReadLine());

                if(matricula == 0)
                {
                    media = soma/cont;
                    Console.WriteLine($"A média total dos alunos é: {media}");
                }
                else 
                {
                    Console.WriteLine("Digite a nota do aluno: ");
                    nota = int.Parse(Console.ReadLine());

                    soma += nota;
                    cont++;
                }
                
            }

        }
    }
}
