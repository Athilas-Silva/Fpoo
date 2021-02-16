using System;

namespace Aula_06___Desafio_Fah
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavél
            double f;
            double c;

            //Entrada
            Console.Write("Qual a temperatura em Fah vc quer converter: ");
            f = Convert.ToSingle(Console.ReadLine());

            //Processamento
            c = (f -32) * 5/9;
            c = Math.Round(c,2);

            //Saida
            Console.Write("A temperatura em Celcius é: " + c);
        }
    }
}
