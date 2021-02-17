namespace Aula_32___Tarefas
{
    public class TestaGerente
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.salario = 1000;

            System.Console.WriteLine("Salário: " + g.salario);

            System.Console.WriteLine("Aumentando o salário em 10% ");
            g.aumentaSalario();

            System.Console.WriteLine("Salário: " + g.salario);

            System.Console.WriteLine("Aumentando o salário em 30% ");
            g.aumentaSalario(0.3);

            System.Console.WriteLine("Salário: " + g.salario);
        }
    }
}