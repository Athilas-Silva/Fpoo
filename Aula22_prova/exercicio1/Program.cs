using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um programa que leia as quatro notas bimestrais de um aluno e calcule sua média final.
            //Se a média final for maior ou igual a 7 então exibir na tela "Aprovado";
            //Se a média final for menor que 5, então exibir "Reproado";
            //Se não exibir "Recuperação.
            //Variavel
            float n1, n2, n3, n4, mf;

            //Entrada
            Console.WriteLine("Informe a primeira nota: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            //Processamento
            mf = (n1 + n2 + n3 + n4) / 4;

            if (mf >= 7)
            {
                Console.WriteLine("Aluno APROVADO");
            }
            else if (mf < 5)
            {
                Console.WriteLine("Aluno REPROVADO");
            }
            else
            {
                Console.WriteLine("Aluno em RECUPERAÇÃO");
            }

            //Saida
            Console.WriteLine("A média é: " + mf);
        }
    }
}
