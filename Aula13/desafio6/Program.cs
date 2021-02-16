using System;

namespace Desafio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            float peso, alt, imc;

            //Entrada
            Console.Write("Qual é seu peso: ");
            peso = Convert.ToSingle(Console.ReadLine());

            Console.Write("Qual sua altura: ");
            alt = Convert.ToSingle(Console.ReadLine());

            //Processamento
            imc = peso / (alt * alt);

            //Saida
            Console.WriteLine("Seu imc é de: " + Math.Round(imc));
            if (imc < 17)
            {
                Console.Write("Muito abaixo do peso");
            }
            else if (imc > 17.1 && imc<= 18.49)
            {
                Console.Write("Abaixo do Peso");
            }
            else if (imc > 18.5 && imc<= 24.99)
            {
                Console.Write("Peso normal");
            }
            else if (imc > 25 && imc <= 29.99)
            {
                Console.Write("Acima do peso");
            }
            else if (imc > 30 && imc <= 34.99)
            {
              Console.Write("Obesidade I");  
            }
            else if (imc > 35 && imc <= 39.99)
            {
                Console.Write("Obesidade II (Severa)");
            }
            else
            {
                Console.Write("Obesidade III (Morbida)");
            }

        }
    }
}
