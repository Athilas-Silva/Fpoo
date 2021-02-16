using System;

namespace Exercicio_K
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            float dolar, cota, conv;

            //Entrada
            Console.Write("Quantos dolares você tem: ");
            dolar = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o valor da cotação: ");
            cota = Convert.ToSingle(Console.ReadLine());

            //Processamento
            conv = dolar * cota;

            //Saida
            Console.Write("Seu valor é: " + conv.ToString("0,00"));
        }
    }
}
