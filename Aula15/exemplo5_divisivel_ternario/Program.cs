using System;

namespace Exemplo_4___Divisivel_com_Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int n;
            string r4, r5;

            //Entrada
            Console.Write("Digite um valor para a divisão: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Processamento e Saida
            r4 = n % 4 == 0 ? "Divisivel" : "Não Divisivel";

            r5 = n % 5 == 0 ? "Divisivel" : "Não Divisivel";

            Console.Write(r4 + " " + r5);
        }
    }
}
