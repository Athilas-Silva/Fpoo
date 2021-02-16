using System;

namespace Exercicio_F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar todos os números divisiveis por 4 que sejam menores que 200.
            //Entrada
            int num = 1;

            //Processamento
            while (num <= 200)
            {
                if (num % 4 == 0)
                {
                    Console.WriteLine("O número " + num + " é divisivel por 4");
                    num++;
                }
                num++;
            }
        }
    }
}
