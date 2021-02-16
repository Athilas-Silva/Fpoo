using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora que converta um número da base numérica decimal para binário e vice-versa.
            //Variavel
            int pri, seg, ter, quar, quin, sex, set, oit, res;

            //Entrada
            Console.WriteLine("Informe o primeiro digito: ");
            oit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            set = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            sex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            quin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            quar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            ter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            seg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro digito: ");
            pri = Convert.ToInt32(Console.ReadLine());

            //Processamento e Saida
            res = pri + (seg * 2) + (ter * 4) + (quar * 8) + (quin * 16) + (sex * 32) + (set * 64) + (oit * 128);

            Console.WriteLine("O número em Decimal é " + res);
        }
    }
}
