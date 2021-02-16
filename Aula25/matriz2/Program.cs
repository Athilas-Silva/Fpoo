using System;

namespace Exemplo_matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz 3 x 2 do tipo string - nome de frutas
            //matriz 3 linhas e 2 colunas
            string[,] frutas = new string[3,2];

            //montar/ler os elementos da matriz frutas 3x2
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 2; j++){
                    Console.WriteLine("Digite uma fruta: ");
                    frutas[i,j] = Console.ReadLine();
                }
            }

            //exibindo os elementos da matriz frutas 3x2
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 2; j++){
                    Console.WriteLine("frutas[{0},{1}] = {2}", i, j, frutas[i,j]);
                }
            }
        }
    }
}
