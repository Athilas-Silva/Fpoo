namespace Aula_32___19_01_21
{
    public class TestaMetodosConta
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(123);

            Conta c = new Conta(a);

            System.Console.WriteLine("Chamando o método deposita passando o valor 1000");
            c.Deposita(1000);
            c.ImprimeExtrato();

            System.Console.WriteLine("Chamando o método saca passando o valor 100");
            c.Saca(100);
            c.ImprimeExtrato();

            System.Console.WriteLine("-------------------------------");

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            System.Console.WriteLine("Saldo Disponivel: " + saldoDisponivel);
        }
    }
}