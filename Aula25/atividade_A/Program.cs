using System;

namespace Atividade_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int[] numeros = new int[10];

            //Lendo os elementos do array numeros
            Console.WriteLine("Exibindo os elementos do array numeros");
            for(int i = 0; i < numeros.Length; i++){
                Console.Write("Digite um número inteiro qualquer: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Exibindo os elementos do array numeros com for
            Console.WriteLine("Exibindo os elementos do array números");
            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
