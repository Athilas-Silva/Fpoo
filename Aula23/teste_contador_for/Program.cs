using System;

namespace Teste
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

            Console.WriteLine("Informe o valor do incremento: ");
            passo = Convert.ToSingle(Console.ReadLine());

            //Processamento
            for(float i = v_inicial; i <= v_final; i+= passo)
            {
                Console.WriteLine(i);
            }
        }
    }
}
