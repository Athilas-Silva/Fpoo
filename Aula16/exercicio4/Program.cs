using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int a;
            string x;

            //Entrada
            Console.Write("Digite o ano: ");
            a = Convert.ToInt32(Console.ReadLine());

            //Processamento
            x = a % 4 == 0 ? "Ano Bissexto" : "O ano não é Bissexto";

            //Saida
            Console.Write(x);
        }
    }
}
