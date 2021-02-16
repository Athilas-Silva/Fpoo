using System;

namespace Array___Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            string[] carros = {"Volvo", "BMW", "Ford", "Mazda"};

            //Processamento
            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }

            foreach (string i in carros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
