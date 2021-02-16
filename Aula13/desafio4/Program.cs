using System;

namespace Desafio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int n1, n2, n3, n4, mf;

            //Entrada
            Console.Write("Qual a primeira nota: ");
            n1 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Qual a segunda nota: ");
            n2 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Qual a terceira nota: ");
            n3 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Qual a quarta nota: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            //Processamento
            mf = (n1 + n2 + n3 + n4) / 4;

            if (mf >= 6)
            {
                Console.WriteLine("Parabéns, aluno Aprovado");
            }
            else{
                Console.WriteLine("Infelizmente o aluno está Reprovado");
            }
            //Saida
            Console.WriteLine("A média é: " + mf);
        }
    }
}
