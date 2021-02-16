using System;

namespace Aula_06___01_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            float c;
            float f;

            //entrada(s)
            Console.Write("Digite a temperatura: ");
            c = Convert.ToSingle(Console.ReadLine());

            //Processamento
            f = (9 * c + 160) / 5;

            //Saida
            Console.Write("Esta temperatura em Fahrenhait é: " + f);
        }
    }
}
