using System;

namespace Exercicio_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            double n1, res;

            //Entrada
            Console.Write("Qual número vai ser calculado: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            res = Math.Sqrt(n1);
            //Saida
            Console.Write("A raiz quadrada é: " + res);
        


        }
    }
}
