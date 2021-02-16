using System;

namespace Operador_Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int n1;
            string x;

            //Entrada
            Console.Write("Digite um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            //Processamento
            x = n1 % 2 == 0 ? "Par" : "Impar"; 

            //Saída
            Console.Write("O número é: " + x);
        }
    }
}
