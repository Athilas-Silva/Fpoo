using System;

namespace Exercicio_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int a, b, c;
            double res;

            //Entrada
            Console.Write("Qual é o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o terceiro valor ");
            c = Convert.ToInt32(Console.ReadLine());

            //Processamento
            res = a + b + c;

            res = Math.Sqrt(res);
            //Saida
            Console.WriteLine("A soma dos valores é: " + res);
        }
    }
}
