using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fatorial de 5
            //Variaveis
            int contador, fatorial;

            fatorial = 1;
            contador = 1;

            while (contador <= 5)
            {
                fatorial = fatorial * contador;
                contador++;
            }
            Console.WriteLine($"O fatorial de 5 é {fatorial}");
        }
    }
}
