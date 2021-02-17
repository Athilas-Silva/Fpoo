namespace Encapsulamento
{
    public class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.limite = 2000;
            c1.saldo = 1000;

            System.Console.WriteLine("Informações sobre a Conta");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("Número: " + c1.numero);
            System.Console.WriteLine("Limite: " + c1.limite);
            System.Console.WriteLine("Saldo: " + c1.saldo);
        }
    }
}