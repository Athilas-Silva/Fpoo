namespace Aula_32___19_01_21
{
    public class TestaContaEAgencia
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(1234);
            Conta c = new Conta(a);

            c.numeroConta = 123;
            c.saldo = 1000.0;
            c.limite = 500;

            System.Console.WriteLine("Dados da Agência");
            System.Console.WriteLine("Número: " + a.numero);

            System.Console.WriteLine("------------------------");

            System.Console.WriteLine("Dados da Conta");
            System.Console.WriteLine("Número: " + c.numeroConta);
            System.Console.WriteLine("Saldo: " + c.saldo);
            System.Console.WriteLine("Limite: " + c.limite);

            System.Console.WriteLine("---------------------------");

            c.agencia = a;

            System.Console.WriteLine("Dados obtidos através da conta");
            System.Console.WriteLine(c.agencia.numero);
        }
    }
}