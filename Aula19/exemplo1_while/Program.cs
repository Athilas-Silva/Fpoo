using System;

namespace Exemplo_1___While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar  os quadrados dos números inteiros de 15 a 200.
            int i = 0; //Valor inicial

            while (i <= 20) //Valor Final
            {
                //Console.WriteLine($"O quadrado de {i} = {Math.Pow(i, 2)}"); //Interpolação
                Console.WriteLine("O quadrado de " + i + " = " + Math.Pow(i, 2)); //Concatenação
                i++; //Passo
            }

        }
    }
}
