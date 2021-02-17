namespace Aula_32___19_01_21
{
    public class TestaConta
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(123);

            Conta c1 = new Conta(a);
            c1.numeroConta = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            Conta c2 = new Conta(a);
            c2.numeroConta = 5678;
            c2.saldo = 2000;
            c2.limite = 250;

            System.Console.WriteLine("Dados da primera conta");
            System.Console.WriteLine("Número: " + c1.numeroConta);
            System.Console.WriteLine("Saldo: " + c1.saldo);
            System.Console.WriteLine("Limite: " + c1.limite);

            System.Console.WriteLine("--------------------------------");

            System.Console.WriteLine("Dados da segunda conta");
            System.Console.WriteLine("Número: " + c2.numeroConta);
            System.Console.WriteLine("Saldo: " + c2.saldo);
            System.Console.WriteLine("Limite: " + c2.limite);
        }
    }
}