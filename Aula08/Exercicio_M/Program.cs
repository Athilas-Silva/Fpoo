using System;

namespace Exercicio_M
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int a, b, c;
            double res;

            //Entrada
            Console.Write("Qual o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            //Processamento
            res = Math.Sqrt(a) + Math.Sqrt(b) + Math.Sqrt(c);            

            //Saida
            Console.WriteLine("O resultado é: " + Math.Round(res)); 

        }
    }
}
