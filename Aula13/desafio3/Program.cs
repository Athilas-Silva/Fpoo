using System;

namespace Desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int num1, num2, num3, soma, med, maior, menor;

            //Entrada
            Console.Write("Digite o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Processamento
            soma = num1 + num2 + num3;

            med = (num1 + num2 + num3) / 3;

            if (num1 > num2)
            {
                maior = num1;
            }
            else if (num1 > num3)
            {
                maior = num1;
            }
            else if (num2 > num3)
            {
                maior = num2;
            }
            else{
                maior = num3;
            }
            if (num1 < num2)
            {
                menor = num1;
            }
            else if (num2 < num3)
            {
                menor = num2;
            }
            else if (num1 < num3)
            {
                menor = num1;
            }
            else
            {
                menor = num3;
            }
            //Saida
            Console.WriteLine("O Maior número digitado foi: " + maior);
            Console.WriteLine("O Menor número digitado foi: " + menor);
            Console.WriteLine("A Soma dos números é de: " + soma);
            Console.WriteLine("A Média dos números é de : " + med);


        }
    }
}
