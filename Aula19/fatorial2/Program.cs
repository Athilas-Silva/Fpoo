using System;

namespace Fatorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar o fatorial de um número dado pelo usuario
            //Variavel
            int num, fat, cot;

            //Entrada
            Console.Write("Informe um valor: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Processamento
            fat = 1;
            cot = 1;
            
            while (cot <= 5)
            {
                fat = num * cot;
                cot++;
            }
            Console.WriteLine("O fatorial é: " + fat);
        }
    }
}
