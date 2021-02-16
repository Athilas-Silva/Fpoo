using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            double salario, novsal;

            //Entrada
            Console.Write("Digite seu Salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            //Processamento e Saida
            if (salario < 500)
            {
                novsal = salario * 1.15;
            }
            else if (salario <= 1000 && salario <= 500)
            {
                novsal = salario * 1.10;
            }
            else
            {
                novsal = salario * 1.05;
            }
            Console.WriteLine("Seu novo salário é: " + novsal.ToString("0.00")); //Concatenação
            Console.WriteLine($"Seu novo salário é: {novsal.ToString("0.00")}"); //Interpolação
        }
    }
}
