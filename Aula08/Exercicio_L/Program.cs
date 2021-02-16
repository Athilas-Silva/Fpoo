using System;

namespace Exercicio_L
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            float real, cota, conv;

            //Entrada
            Console.Write("Quanto você quer converter: ");
            real = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual a cotação do Real: ");
            cota = Convert.ToSingle(Console.ReadLine());

            //Processamento
            conv = real * cota;

            //Saida
            Console.Write("Seu valor é de: " + conv + "R$");
        }
    }
}
