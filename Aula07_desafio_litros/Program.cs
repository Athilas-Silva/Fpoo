using System;

namespace Aula_07___Desafio_em_Litros
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel
            float Tem, Vel, Dis, Lit;

            //entrada
            Console.Write("Quanto tempo vc gastou: ");
            Tem = Convert.ToSingle(Console.ReadLine());

            Console.Write("Qual a velocidade: ");
            Vel = Convert.ToSingle(Console.ReadLine());

            //processamento
            Dis = Tem * Vel;

            Lit = Dis / 12;

            //saida
            Console.WriteLine("O tempo gasto na viagem foi de: " + Math.Round(Tem, 2));
            Console.WriteLine("A Velocidade média foi de: " + Math.Round(Vel, 2));
            Console.WriteLine("A Distância percorrida foi de: " + Math.Round(Dis, 2));
            Console.WriteLine("O Consumo em Litros foi de: " + Math.Round(Lit, 2));
        }
    }
}
