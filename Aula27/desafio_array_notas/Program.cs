using System;

namespace Desafio_Array___Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informando as notas, médias e situação do aluno na escola.
            //Declarando a matriz e o vetor
            string[] alunos = new string[3];
            string[] situacao = new string[3];
            float[,] notas = new float[3,4];
            float[] soma = new float[3]{0, 0, 0};
            float[] media = new float[3];

            //Entrada da Array
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("--------------------------------");
                Console.Write($"Informe o nome do aluno {i+1}º Aluno: ");
                alunos[i] = Console.ReadLine();

                for(int j = 0; j < 4; j++)
                {
                    Console.Write($"Informe a nota {j + 1} do aluno {alunos[i]}: ");
                    notas[i,j] = float.Parse(Console.ReadLine());
                    soma[i] = soma[i] + notas[i,j];
                    media[i] = soma[i] / 4;
                }

            }

            for(int i = 0; i <media.Length; i++)
            {
                Console.WriteLine("-----------------------------------");
                if (media[i] >= 7)
                {
                    Console.WriteLine($"{alunos[i]} esá aprovado \t media = {Math.Round(media[i], 2)}");
                }

                else if (media[i] < 5)
                {
                    Console.WriteLine($"{alunos[i]} está reprovado \t média = {Math.Round(media[i], 2)}");
                }

                else
                {
                    Console.WriteLine($"{alunos[i]} está em recuperação \t media = {Math.Round(media[i], 2)}");
                }
            }
        }
    }
}
