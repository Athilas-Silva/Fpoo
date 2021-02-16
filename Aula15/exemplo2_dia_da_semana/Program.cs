using System;

namespace Exemplo_2___Dia_da_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int dia;

            //Entrada
            Console.Write("Digite um número de 1 a 7: ");
            dia = Convert.ToInt32(Console.ReadLine());

            //Processamento e Saida
            switch (dia)
            {
                case 1:
                Console.Write("Domingo");
                break;

                case 2:
                Console.Write("Segunda-Feira");
                break;

                case 3:
                Console.Write("Terça-Feira");
                break;

                case 4:
                Console.Write("Quarta-Feira");
                break;

                case 5:
                Console.Write("Quinta-Feira");
                break;

                case 6:
                Console.Write("Sexta-Feira");
                break;

                case 7:
                Console.Write("Sábado");
                break;

                default:
                Console.Write("Digito Inválido");
                break;
            }
        }
    }
}
