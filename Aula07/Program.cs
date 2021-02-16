using System;

namespace Aula_07___06_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            double altura, raio, vol;

            //Entrada
            Console.Write("Qual a altura da Lata: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual o raio da Lata: ");
            raio = Convert.ToDouble(Console.ReadLine());

            //Processamento
            vol = 3.1415 * Math.Pow(raio, 2) * altura;

            //Saida
            Console.Write("O volume da Lata é: " + vol);
        }
    }
}
