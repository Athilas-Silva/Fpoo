using System;

namespace Fatorial_com_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar o Fatorial de 5
            //Variavel
            int fat;

            //Estrutura de Repetição For
            for (int i = 1; i <= 5; i++)
            {
                fat = i * 5;
                Console.WriteLine("O fatorial de 5 é igual a " + fat);
            }
        }
    }
}
