using System;

namespace Fatorial___Correção
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int num, contador = 1, fatorial = 1;

            //Calcular o fatorial de um número inteiro informado pelo usuário.
            //Entrada
            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Processamento
            while (contador <= num)
            {
                fatorial = fatorial * contador;
                contador = contador + 1;
            }

            //Saida
            Console.WriteLine($"O fatorial de {num} = {fatorial}");
        }
    }
}
