using System;

namespace Aula_32___Tarefas
{
    public class TestaMetodosConta
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.WriteLine("Chamando o método deposita passando o valor 1000");
            c.Deposita(1000);
            c.ImprimeExtrato();

            Console.WriteLine("---------------------------");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Chamando o método saca passando o valor 100");
            c.Saca(100);
            c.ImprimeExtrato();

            Console.WriteLine("--------------------------");

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine("Saldo Disponivel: " + saldoDisponivel);
        }
    }
}