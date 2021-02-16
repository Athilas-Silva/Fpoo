using System;

namespace Exemplo_3___Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int a, b, c;

            //Entrada
            Console.Write("Digite o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            //Processamento e Saida
            if (a == b  && b == c && a ==c)
            {
                Console.WriteLine("Triangulo Equilatero");
            }
            else if ((a == b && a != c) || (a == c && a != b) || (b == c && a!= c))
            {
                Console.WriteLine("Triangulo Isoceles");
            }
            else
            {
                Console.WriteLine("Triangulo Escaleno");
            }

        }
    }
}
