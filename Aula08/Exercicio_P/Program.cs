using System;

namespace Exercicio_P
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            float sm, pr, ns;

            //Entrada
            Console.Write("Digite o salário: ");
            sm = Convert.ToSingle(Console.ReadLine());

            Console.Write("Qual será a taxa de acréscimo: ");
            pr = Convert.ToSingle(Console.ReadLine());

            //Processamento
            ns = sm * pr / (100);

            //Saida
            Console.WriteLine("O acréscimo é de R$ " + ns);
            Console.WriteLine("O novo salário será R$: " + (ns + sm));
        }
    }
}
