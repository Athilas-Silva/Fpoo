using System;

namespace Exercicio_Q
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            double a, r;

            //Entrada
            Console.Write("Informe o valor do Raio: ");
            r = Convert.ToSingle(Console.ReadLine());

            //Processamento
            a = 3.14 * Math.Pow(r, 2);

            //Saida
            Console.Write("A aréa é de: " + a);
        }
    }
}
