using System;

namespace Exercicio_H
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variavel
            double vol, comp, lar, alt;

            //Entrada
            Console.Write("Qual o comprimento da caixa: ");
            comp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a largura da caixa: ");
            lar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a altura da caixa: ");
            alt = Convert.ToDouble(Console.ReadLine());

            //Processamento
            vol = comp * lar * alt;

            vol = Math.Round(vol, 2);

            //Saida
            Console.Write("O volume da  caixa é de: " + vol);
        }
    }
}
