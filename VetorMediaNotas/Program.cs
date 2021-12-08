// Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos e calcular a média 
// aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota 
// acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5. 

using System;
using System.Collections.Generic;

namespace VetorMediaNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de alunos: ");
            var alunos = int.Parse(Console.ReadLine());

            var notasAlunos = new int[alunos];
            var notaBaixa = 0;
            List<int> notas = new List<int>();
            List<int> totalNotas = new List<int>();

            for(var i = 0; i < notasAlunos.Length; i++)
            {
                Console.WriteLine($"Digite a nota do {i + 1}º aluno: ");
                notasAlunos[i] = int.Parse(Console.ReadLine());

                notas.Add(notasAlunos[i]);
            }

            foreach(var nota in notas)
            {
                if(nota > 7)
                    totalNotas.Add(nota);

                if(nota <= 5 )
                    notaBaixa++;                    
            }

            if(notaBaixa == alunos)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
            else{
                Console.WriteLine($"O total de alunos com a nota acima de 7.0 é: {totalNotas.Count}");
            }

            Console.ReadKey();
        }
    }
}
