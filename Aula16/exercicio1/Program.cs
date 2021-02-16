using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            float x;

            //Entrada
            Console.Write("Digite o numero: ");
            x = Convert.ToSingle(Console.ReadLine());

            //Processamento

            if (x > 0)
            {
                Console.Write("O número é POSITIVO");
            }
            else if (x < 0)
            {
                Console.Write("o número é NEGATIVO");
            }
            else
            {
                Console.Write("O número é NEUTRO");
            }
        }
    }
}
