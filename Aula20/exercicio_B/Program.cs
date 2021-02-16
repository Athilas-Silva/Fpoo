using System;

namespace Exercicio_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar os resultados de uma taboada de um número qualquer.
            //Variavel
            int num, contador = 0;


            //Entrada
            Console.WriteLine("Informe o número para a tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Processamento
            while (contador < 11)
            {
                Console.WriteLine(num + " x " + contador + " = " + num * contador);
                contador = contador + 1;
            }
        }
    }
}
