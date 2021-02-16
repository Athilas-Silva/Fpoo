using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um programa que apresente no final o total da soma obtida dos 100 primeiros
            //números inteiros dos valores entre 50 e 100

            //Entrada
            int num = 50,soma = 0;

            //Processamento
            while (num <= 100) 
            {
                soma = soma + num; 
                num++;
            }
            Console.WriteLine("A soma é " + soma);
        }
    }
}
