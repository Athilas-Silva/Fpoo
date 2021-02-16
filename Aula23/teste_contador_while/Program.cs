using System;

namespace Teste___Contador_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contador com as informações fornecidas pelo usuário
            //Variavel
            float v_inicial, v_final, passo;

            //Entrada
            Console.WriteLine("Informe o valor inicial: ");
            v_inicial = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o valor final: ");
            v_final = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o incremento: ");
            passo = Convert.ToSingle(Console.ReadLine());

            //Processamento e Saida
            while (v_inicial <= v_final)
            {
                Console.WriteLine("A contagem é: " + v_inicial);
                v_inicial += passo;
            }
        }
    }
}
