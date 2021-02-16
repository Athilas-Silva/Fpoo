using System;

namespace Atividade_D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando os vetores
            double[] vetorA = new double[4];
            double[] vetorB = new double[4];

            //Lendo os vetores
            for(int i = 0; i < vetorA.Length; i++){
                Console.Write("Digite um valor para o vetorA: ");
                vetorA[i] = Convert.ToDouble(Console.ReadLine());

                vetorB[i] = Math.Pow(vetorA[i], 2);
            }

            //Exibindo os vetores
            for(int i = 0; i < vetorA.Length; i++){
                Console.WriteLine($"vetorA[{i}] = {vetorA[i]} \t vetorB[{i}] = {vetorB[i]}");
            }
        }
    }
}
