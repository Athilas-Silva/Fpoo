using System;

namespace Exercicio_H
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elaborar um programa que apresente como resultado o valor de uma potência de uma base qualquer
            //elevada a um expoente qualquer.
            //Variavel
            int b, e;

            //Entrada
            Console.WriteLine("Informe um número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a potencia do número: ");
            e = Convert.ToInt32(Console.ReadLine());

            //Processamento e Saida
            Console.Write("O resultado é: " + Math.Pow(b, e));
        }
    }
}
