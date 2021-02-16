using System;

namespace Exercicio_E
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            float Pres, valor, taxa, temp;

            //Entrada
            Console.Write("Qual o valor do produto: ");
            valor = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o valor da taxa: ");
            taxa = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Quanto tempo você atrasou: ");
            temp = Convert.ToSingle(Console.ReadLine());

            //Processamento
            Pres = valor + (valor * (taxa/100) * temp);
            
            //Saida
            Console.Write("O valor da prestação é: " + Pres.ToString("0,00"));
        }
    }
}
