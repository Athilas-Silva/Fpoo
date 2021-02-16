using System;

namespace Atividade_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int[] vetorA = new int[8];
            int[] vetorB = new int[8];

            //Lendo os elementos do VetorA e construindo o vetorB
            Console.WriteLine("Lendo os elementos do vetorA e construindo o vetorB");
            for(int i = 0; i < vetorA.Length; i++){
                Console.Write("Digite um elemento para o vetorA: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
                vetorB[i] = vetorA[i] * 3;
            }

            //Exibindo os elementos do VetorB multiplicado por 3
            for(int i = 0; i < vetorA.Length; i++){
                Console.WriteLine($"vetorA[{i}] = {vetorA[i]} \t vetorB[{i}] = {vetorB[i]}");
            }
            
            //  \n = new line ou quebra de linha
            //  \t = tabulação
        }
    }
}
