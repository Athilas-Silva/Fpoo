using System;

namespace Exemplo_matriz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz 4x4
            //Variavel
            int [,] numeros = new int[4,4];

            //Entrada da matriz
            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.WriteLine($"número [{i},{j}] = ");
                    numeros[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Exibindo os elementos diagonal principal
            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if (i == j)
                    {
                        Console.WriteLine("Números [{0},{1}] = {2}", i, j, numeros[i, j]);
                    }
                }
            }
        }
    }
}
