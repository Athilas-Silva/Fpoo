using System;

namespace Exercicio_D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de 1 a 500.
            //Variavel
            int num = 1, soma = 0;

            //Processamento
            while (num < 501)
            {
                if (num % 2 == 0)
                {
                    soma = soma + num;
                    num++;
                }
                num++;
                Console.WriteLine("A soma é " + soma);
            }
        }
    }
}
