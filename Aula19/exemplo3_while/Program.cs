using System;

namespace Exemplo_3___While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int i, num;
            i = 1;

            //Processamento
            while (i <= 5)
            {
                Console.WriteLine("Digite um número: " + i);
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Número {i} = {num}");
                i++;
            }
            
        }
    }
}
