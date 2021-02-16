using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado um endereço IPv4 exibir na tela a classe do mesmo.
            //Variavel
            float ip4;

            //Entrada
            Console.WriteLine("Digite somente números e somente os 3 primeiros digitos");

            Console.WriteLine("Informe o endereço IPV4: ");
            ip4 = Convert.ToInt32(Console.ReadLine());

            //Processamento

            //A classe A possui um conjunto de endereços que vão desde o 1.0.0.0 até 127.0.0.0
            //onde o primeiro octeto (primeiros 8 bits N.H.H.H) de um endereço IP identifica  a rede e os
            //restantes 3 octetos ( 24 bits) irão identificar um determinado host nessa rede.

            if (ip4>= 1 && ip4 <= 120)
            {
                Console.WriteLine("Seu IPV4 é de classe A");
            }

            //A classe B possui um conjunto de endereços que vão desde o 128.0.0.0 até 191.255.0.0,
            //onde os dois primeiros octetos (16 bits N.N.H.H) de um endereço IP identificam  a rede
            //e os restantes 2 octetos ( 16 bits) irão identificar um determinado host nessa rede.

            else if (ip4 >= 128 && ip4 <= 191)
            {
                Console.WriteLine("Seu IPV4 é de classe B");
            }

            //A classe C possui um conjunto de endereços que vão desde o 192.0.0.0 até 223.255.255.0
            //onde os três primeiros octetos (24 bits N.N.N.H) de um endereço IP identificam  a rede
            //e o restante octeto ( 8 bits) irão identificar um determinado host nessa rede.

            else if (ip4 >= 192 && ip4 <= 223)
            {
                Console.WriteLine("Seu IPV4 é de classe C");
            }

            else{
                Console.WriteLine("IPV4 não definido");
            }
        }
    }
}
