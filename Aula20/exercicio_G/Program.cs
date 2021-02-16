using System;

namespace Exercicio_G
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar os resultados das potências de 3 variando do expoente 0 até o 15.
            //Variavel
            int num = 3, exp = 0;

            //Processamento
            while (exp <= 15)
            {
                Console.WriteLine("A potência de 3 é = " + Math.Pow(num, exp));
                exp++;
            }
        }
    }
}
