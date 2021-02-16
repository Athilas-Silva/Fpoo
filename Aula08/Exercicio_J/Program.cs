using System;

namespace Exercicio_J
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            int a, b;
            double res;

            //Entrada
            Console.Write("Informe o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Processamento
            res = a - b;
            Console.WriteLine("O resultado é: " + res);
            res = Math.Sqrt(res);

            //saida
            Console.Write("O resultado da raiz é: " + Math.Round(res));

        }
    }
}
