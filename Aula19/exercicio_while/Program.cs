using System;

namespace Exercicio_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 15;

            while (i <= 200)
            {
                Console.WriteLine("O quadrado de " + i + " é igual " + Math.Pow(i, 2));
                i++;
            }
        }
    }
}
