using System;

namespace Exercicio_G
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int A, B, C, D;

            //Entrada
            Console.Write("Valores a serem atribuidos");
            Console.WriteLine("---------------------");
            Console.WriteLine("Qual valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual valor de D: ");
            D = Convert.ToInt32(Console.ReadLine());

            //Saida
            Console.WriteLine("A soma de A e B é: " + (A + B));
            Console.WriteLine("A multiplicação de A e B é: " + A*B);
            Console.WriteLine("A soma de A e C é: " + (A + C));
            Console.WriteLine("A multiplicação de A e C é: " + A*C);
            Console.WriteLine("A soma de A e D é: " + (A + D));
            Console.WriteLine("A multiplicação de A e D é: " + A*D);
            Console.WriteLine("A soma de B e C é: " + (B + C));
            Console.WriteLine("A multiplicação de B e C é: " + B*C);
            Console.WriteLine("A soma de B e D é: " + (B + D));
            Console.WriteLine("A multiplicação de B e D é: " + B*D);
            Console.WriteLine("A soma de C e D é: " + (C + D));
            Console.WriteLine("A multiplicação de C e D é: " + C*D);
        }
    }
}
