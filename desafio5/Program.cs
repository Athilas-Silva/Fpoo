using System;

namespace Desafio_5
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

            if (mf < 5)
            {
                Console.WriteLine("O aluno está REPROVADO");
            }
            else if (mf >= 7)
            {
                Console.WriteLine("Parabéns o Aluno está APROVADO");
            }
            else{
                Console.WriteLine("O aluno está em RECUPERAÇÃO");
            }
           
            //Saida
            Console.Write("A média do Aluno é: " + mf);
        }
    }
}
