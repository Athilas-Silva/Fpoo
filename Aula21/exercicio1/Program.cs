using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número qualquer e exiba na tela se o mesmo é "Par" ou "Ímpar". NÃO UTILIZAR A FUNÇÃO MOD
            //PARA A CODIFICAÇÃO DESTE EXERCÍCIO.
            //Variavel
            float num, quociente, res;

            //Entrada
            Console.Write("Informe um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Processamento e Saida
            quociente = num / 2;
            res = num - 2 * quociente;

            Console.WriteLine("O resultado é " + quociente);

            if (res == num - 2 * (2))
            {
                Console.WriteLine("O número é Par");
            }
            else
            {
                Console.WriteLine("O número é Impar");
            }
        }
    }
}
