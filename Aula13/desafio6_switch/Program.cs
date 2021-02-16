using System;

namespace Desafio_6___Switch
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

            switch (imc)
            {
                case var _ when imc <= 17:
                Console.WriteLine("Muito Abaixo do Peso");
                break;
                case var _ when imc <= 18.49:
                Console.WriteLine("Abaixo do Peso");
                break;
                case var _ when imc <= 24.99:
                Console.WriteLine("Peso Normal");
                break;
                case var _ when imc <= 29.99:
                Console.WriteLine("Acima do Peso");
                break;
                case var _ when imc <= 34.99:
                Console.WriteLine("Obesidade I");
                break;
                case var _ when imc <= 39.99:
                Console.WriteLine("Obesidade II");
                break;
                case var _ when imc >= 40:
                Console.WriteLine("Obesidade III");
                break;

            }

            //Saida
            Console.Write("Seu IMC é de: " + imc.ToString("0.00"));
        }
    }
}
