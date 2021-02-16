using System;

namespace Exemplo_de_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int i;

            //Estrutura de Repetição For
            //Processamento do exercicio
            for (i = 15; i < 201; i++)
            {
                //Enquanto a condição for VERDADEIRA
                Console.WriteLine("O quadrado de " + i + " é igual a " + Math.Pow(i, 2));
                //Console.WriteLine($"O quadrado de {i} = {Math.Pow(i, 2)}");
            }

        }
    }
}
