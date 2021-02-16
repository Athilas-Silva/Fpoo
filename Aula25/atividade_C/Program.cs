using System;

namespace Atividade_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int[] vetorA = new int[4];
            int[] vetorB = new int[4];
            int[] vetorC = new int[4];

            for(int i = 0; i < vetorA.Length; i++){
                Console.Write("Digite um valor para o vetorA: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite um valor para o vetorB: ");
                vetorB[i] = Convert.ToInt32(Console.ReadLine());

                vetorC[i] = vetorA[i] - vetorB[i];
            }

            //Exibindo os valores do vetor
            for(int i = 0; i < vetorA.Length; i++){
                Console.WriteLine($"vetorA[{i}] = {vetorA[i]} \t vetorB[{i}] = {vetorB[i]} \t vetorC[{i}] = {vetorC[i]}");
            }
        }
    }
}
