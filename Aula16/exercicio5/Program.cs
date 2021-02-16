using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            double a, b, c, delta, x1, x2, x0;

            //Entrada
            Console.Write("Digite o primeiro valor: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = Convert.ToSingle(Console.ReadLine());

            //Processamento
            delta = (b * b) - 4 * a *c;
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            x0 = (-b / (2 * a));

            if (delta < 0)
            {
                Console.Write("A equação não possui raizes");
            }
            else if (delta > 0)
            {
                Console.WriteLine("Resultado x1 = " + Math.Round(x1));
                Console.WriteLine("Resultado x2 = " + Math.Round(x2));
            }
            else
            {
                Console.WriteLine("Resultado = " + x0);
            }
        }
    }
}
