using System;

namespace Exercicio_O
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varíavel
            int a, b, c, d, p, s;

            //Entrada
            Console.Write("Qual o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o quarto valor: ");
            d = Convert.ToInt32(Console.ReadLine());

            //Processamento
            p = a + c;

            s = b + d;

            //Saída
            Console.WriteLine("O valor do produto A e C é de: " + p);
            Console.WriteLine("O valor do produto B e D é de: " + s);

        }
    }
}
