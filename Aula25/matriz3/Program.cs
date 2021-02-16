using System;

namespace Exemplo_matriz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // matriz 2 x 4 de carros
            //Ler os elementos da matriz com a estrutura de repetição for()
            //Variavel
            string[,] carros = new string[2,4];

            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 4; j++){
                    Console.WriteLine("Digite o nome de um carro: ");
                    carros[i,j] = Console.ReadLine();
                }
            }

            //Exibir a matriz com a estrutura de repetição foreach()
            foreach(string car in carros){
                Console.WriteLine(car);
            }
        }
    }
}
