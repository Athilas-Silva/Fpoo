using System;

namespace Exercicio_3
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

            Console.Write("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            //Processamento
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b  && b == c && a ==c)
                {
                    Console.WriteLine("Triângulo Equilatero");
                }
            else if ((a == b && a != c) || (a == c && a != b) || (b == c && a!= c))
                {
                    Console.WriteLine("Triângulo Isoceles");
                }
            else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.Write("As medidas não formam um triângulo");
            }
            
        }
    }
}
