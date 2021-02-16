using System;

namespace Exercicio_R
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int a, b, c, votovalido, totaleleitor, votonulo, votobranco;
            float por_tot_vali, por_a_valid, por_b_valid, por_c_valid, por_nulo, por_branco;

            //Entrada
            Console.Write("Quantos votos o Candidato A teve? ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos votos o Candidato B teve? ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos votos o Candidato C teve? ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos votos Nulos teve? ");
            votonulo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos votos brancos teve? ");
            votobranco = Convert.ToInt32(Console.ReadLine());


            //Processamento
            votovalido = a + b + c;

            totaleleitor = votovalido + votonulo + votobranco;

            por_tot_vali = (votovalido * 100) / totaleleitor;

            por_nulo = (votonulo * 100) / totaleleitor;

            por_branco = (votobranco * 100) / totaleleitor;

            por_a_valid = (a * 100) / totaleleitor;

            por_b_valid = (b * 100) / totaleleitor;

            por_c_valid = (c * 100) / totaleleitor;

            //Saida
            Console.WriteLine("O total de eleitores foi de: " + totaleleitor);
            Console.WriteLine("O total de votos validos foi: " + por_tot_vali);
            Console.WriteLine("O total de votos nulos foi de: " + por_nulo);
            Console.WriteLine("O total de votos brancos foi de: " + por_branco);
            Console.WriteLine("A porcentagem do candidato A é: " + por_a_valid);
            Console.WriteLine("A porcentagem do candidato B é: " + por_b_valid);
            Console.WriteLine("A porcentagem do candidato C é: " + por_c_valid);
        }
    }
}
