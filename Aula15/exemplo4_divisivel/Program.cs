using System;

namespace Exemplo_4___Divisivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int n, r_4, r_5;

            //Entrada
            Console.Write("Digite um valor para a divisão: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Processamento
            r_4 = n - 4 * (n  / 4);

            r_5 = n - 5 * (n / 5);

            //Saida
            if (r_4 == 0 && r_5 == 0)
            {
                Console.Write(n);
            }
            else
            {
                Console.Write("Não é divisivel por 4 e 5");
            }
        }
    }
}
