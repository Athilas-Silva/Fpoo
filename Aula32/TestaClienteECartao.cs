using System;

namespace Aula_32___19_01_21
{
    class TestaClienteECartao
    {
        static void Main(string[] args)
        {
            //Criando um objeto de cada classe
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito(111111);

           c.nome = "Rafael Cosentino";
           c.codigo = 123;

           cdc.dataDeValidade = "12/12/18";

           Console.WriteLine("Dados do cliente");
           Console.WriteLine("Nome: " + c.nome);
           Console.WriteLine("Código: " + c.codigo);
           Console.WriteLine("--------------------");

           Console.WriteLine("Dados do cartão");
           Console.WriteLine("Número: " + cdc.numeroConta);
           Console.WriteLine("Data de validade: " + cdc.dataDeValidade);
           Console.WriteLine("--------------------");

            //ligando os objetos
           cdc.cliente = c;

           Console.WriteLine("Dados do cartão obtidos através do cartão");
           Console.WriteLine(cdc.cliente.nome);
           Console.WriteLine(cdc.cliente.codigo);
        }
    }
}