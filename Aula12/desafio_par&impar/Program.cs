using System;

namespace Aula_12___27_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varíavel
            int num;

            //Entrada
            Console.Write("Digite o número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Saída
            if (num % 2 == 0)
            Console.WriteLine("O número é Par");

            else
            {
               Console.WriteLine("O número é Impar");
            }

        }
    }
}
