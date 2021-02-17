namespace Aula_32___19_01_21
{
    public class TestaValoresPadrao
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(123);

            Conta c = new Conta(a);
            
            System.Console.WriteLine("Valores Padrão");
            System.Console.WriteLine("Número: " + c.numeroConta);
            System.Console.WriteLine("Saldo: " + c.saldo);
            System.Console.WriteLine("Limite: " + c.limite);
        }
    }
}