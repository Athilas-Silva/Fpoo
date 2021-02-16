using System;

namespace Desafio_Array_v2___Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis array
            string[] alunos = new string[5];
            float[,] notas = new float[5,4];
            float[] soma = new float[5]{0, 0, 0, 0, 0};
            float[] media = new float[5];

            //Criando matriz e o vetor
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("-----------------------------------------");
                Console.Write($"Informe o nome do {i + 1} Aluno: ");
                alunos[i] = Console.ReadLine();

                    for(int j = 0; j < 4; j++)
                    {
                        Console.Write($"Informe a nota {j + 1} do aluno {alunos[i]}: ");
                        notas[i,j] = float.Parse(Console.ReadLine());
                        soma[i] = soma[i] + notas[i,j];
                        media[i] = soma[i] / 4;
                    }

                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Nome \t Situação \t Média \t Nota1 \t Notas2 \t Nota3 \t Nota4 ");
            }

            for(int i = 0; i < media.Length; i++)
            {
                if (media[i] >= 7)
                {
                    Console.Write($"{alunos[i]} \t APROVADO \t {Math.Round(media[i], 2)} \t ");
                    for(int j = 0; j < 4; j++)
                    {
                        Console.Write($"{notas[i,j]}\t");
                    }
                    Console.WriteLine("\n");

                }

                else if (media[i] < 5)
                {
                    Console.Write($"\n{alunos[i]} \t REPROVADO \t {Math.Round(media[i], 2)} \t ");
                    for(int j = 0; j < 4; j++)
                    {
                        Console.Write($"{notas[i,j]}\t");
                    }
                    Console.WriteLine("\n");
                }

                else{
                    Console.Write($"\n {alunos[i]} \t RECUPERAÇÃO \t {Math.Round(media[i], 2)} \t ");
                    for(int j = 0; j < 4; j++)
                    {
                        Console.Write($"{notas[i,j]}\t");
                    }
                    Console.WriteLine("\n");
                }
            }

        }
    }
}
