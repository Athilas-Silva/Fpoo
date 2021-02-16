using System;

namespace Exercicio_E
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar todos os valores numéricos inteiros impares situados na faixa de 0 a 20.
            //Variavel
            int num = 1;

            //Processamento
            while (num <= 20)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine("O número" + num + " é impar");
                    num++;
                }
                num++;
            }
        }
    }
}
