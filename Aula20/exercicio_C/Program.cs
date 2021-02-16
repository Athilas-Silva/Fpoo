using System;

namespace Exercicio_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar o total da soma obtida dos 100 primeiros números inteiros.
            //Entrada
            int num = 1,soma = 0;

            //Processamento
            while (num < 101) //valor final
            {
                soma = soma + num; //valor inicial
                num++; //passo
            }
            Console.WriteLine("A soma é " + soma); //resultado
        }
    }
}
