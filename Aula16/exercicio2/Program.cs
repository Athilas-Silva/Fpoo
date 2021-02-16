using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            float x;
            string z;

            //Entrada
            Console.Write("Digite o valor: ");
            x = Convert.ToSingle(Console.ReadLine());

            //Processamento e Saida
            if (x > 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else if (x < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else{
                Console.WriteLine("NEUTRO");
            }
            z = x % 2 == 0 ? "Par" : "Impar";

            Console.WriteLine("Este número é: " + z);

        }
    }
}
