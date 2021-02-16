using System;

namespace Aula_05___29_09_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            int num1, num2, soma;

            //Entradas
            Console.Write("Digite o primeiro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Processador
            soma = num1 + num2;
            
            //Saida
            Console.Write("A soma é:" + soma);
        }
    }
}
