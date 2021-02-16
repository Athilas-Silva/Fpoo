using System;

namespace Exemplo_For_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int num1, num2, num3, num4, num5;
            int i;

            //Entrada
            Console.Write("Digite o número 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 4: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 5: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            //Processamento
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("O resultado é: " + i);
            }
        }
    }
}
