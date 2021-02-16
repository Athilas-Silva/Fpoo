using System;

namespace Arrays___Média_Geral
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            float [] md = new float[8];
            float soma = 0;

            //Entrada
            Console.WriteLine("Obtendo as médias dos alunos \n");
            for (int i = 0; i < md.Length; i++)
            {
                Console.WriteLine("Digite a nota do {0}º aluno: ", i + 1);
                md[i] = Convert.ToSingle(Console.ReadLine());
                soma = soma + md[i];
            }
            float mg = soma / 8;

            Console.Write("\n A média geral da sala é: " + mg);
            
        }
    }
}
