namespace Aula_32___19_01_21
{
    public class TestaMetodoTransfere
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(1234);
            Conta origem = new Conta(a);

            origem.saldo = 1000;
            System.Console.WriteLine("Saldo da primeira conta: " + origem.saldo);

            Conta destino = new Conta(a);
            destino.saldo = 1000;
            System.Console.WriteLine("Saldo da segunda conta: " + destino.saldo);

            System.Console.WriteLine("------------------------------");

            System.Console.WriteLine("Realizando a transferencia");
            origem.Transfere(destino, 500);

            System.Console.WriteLine("--------------------------------");

            System.Console.WriteLine("Saldo da primera conta: " + origem.saldo);
            System.Console.WriteLine("Saldo da segunda conta: " + destino.saldo);
        }
    }
}