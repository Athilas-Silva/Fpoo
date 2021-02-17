namespace Aula_39_09_02_21
{
    public class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Athilas Silva";
            g.Salario = 3000;
            g.Usuario = "athilas silva";
            g.Senha = "12345";

            Telefonista f = new Telefonista();
            f.Nome = "Nicole Cristine";
            f.Salario = 1500;
            f.EstacaoDeTrabalho = 10;

            Secretaria s = new Secretaria();
            s.Nome = "Amanda Cristine";
            s.Salario = 1200;
            s.Ramal = 100;

            System.Console.WriteLine("GERENTE");
            // System.Console.WriteLine("Nome: " + g.Nome);
            // System.Console.WriteLine("Salário: " + g.Salario);
            // System.Console.WriteLine("Usuário: " + g.Usuario);
            // System.Console.WriteLine("Senha: " + g.Senha);
            // System.Console.WriteLine("Bonificação: " + g.CalcularBonificacao());
            g.MostraDados();


            System.Console.WriteLine("-------------------------------");

            System.Console.WriteLine("TELEFONISTA");
            // System.Console.WriteLine("Nome: " + f.Nome);
            // System.Console.WriteLine("Salário: " + f.Salario);
            // System.Console.WriteLine("Estação de Trabalho: " + f.EstacaoDeTrabalho);
            // System.Console.WriteLine("Bonificação: " + f.CalcularBonificacao());
            f.MostraDados();

            System.Console.WriteLine("--------------------------------------");

            System.Console.WriteLine("SECRETARIA");
            // System.Console.WriteLine("Nome: " + s.Nome);
            // System.Console.WriteLine("Salário: " + s.Salario);
            // System.Console.WriteLine("Ramal: " + s.Ramal);
            // System.Console.WriteLine("Bonificação: " + s.CalcularBonificacao());
            s.MostraDados();
        }
    }
}