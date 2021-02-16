using System;

namespace Aula_12___Bínario___Decimal__27_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            int pri, seg, ter, quar, quin, sex, set, oit, res;

            //Entrada
            Console.Write("Qual o primeiro digito: ");
            oit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o segundo digito: ");
            set = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o terceiro digito: ");
            sex = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o quarto digito: ");
            quin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o quinto digito: ");
            quar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o sexto digito: ");
            ter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o sétimo digito: ");
            seg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o oitavo digito: ");
            pri = Convert.ToInt32(Console.ReadLine());

            //Processamento
            res = pri + (seg * 2) + (ter * 4) + (quar * 8) + (quin * 16) + (sex * 32) + (set * 64) + (oit * 128);

            //Saida
            Console.Write("O número em Decimal é: " + res);
        }
    }
}
