using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um programa que exiba o quadrado dos números pares de 0 a 20.
            //Entrada
            int i = 0;

            //Processamento
            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                Console.WriteLine("O quadrado de " + i + " = " + Math.Pow(i, 2)); 
                }
                i++;
            }
        }
    }
}
