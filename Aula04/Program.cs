using System;

namespace Aula_04___24_09_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somando dois valores
            
            int n1, n2, resultado;
            Console.WriteLine("Informe o 1 numero - >");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2 numero - >");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("Resultado");
            Console.Write(resultado);        
            Console.ReadKey();

        }
    }
}
