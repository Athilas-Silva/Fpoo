using System;

namespace Teste___Contador_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            float v_inicial, v_final, passo;

            //Entrada
            Console.WriteLine("Informe o valor inicial: ");
            v_inicial = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o valor final: ");
            v_final = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o incremento ou decremento: ");
            passo = Convert.ToSingle(Console.ReadLine());

            //Processamento e Saida
            if (v_inicial <= v_final)
            {
                while (v_inicial <= v_final)
                {
                Console.WriteLine("A contagem é: " + v_inicial);
                v_inicial += passo;
                }
            }
            else if (v_inicial >= v_final)
            {
                while (v_inicial >= v_final)
                {
                Console.WriteLine("A contagem é: " + v_inicial);
                v_inicial = v_inicial - passo;
                }
            }
        }
    }
}
