namespace Aula_38_08_02_21
{
    public class TestaPessoaJuridica
    {
        static void Main(string[] args)
        {
            Juridica j1 = new Juridica();

            j1.Nome = "João Aleatório";
            j1.dtNascimento = "07/10/1999";
            j1.CNPJ = "12345678-90";

            System.Console.WriteLine("Dados da Pessoa Juridica");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Nome: " + j1.Nome);
            System.Console.WriteLine("Data de Nascimento: " + j1.dtNascimento);
            System.Console.WriteLine("CNPJ: " + j1.CNPJ);
            j1.Comer("Juridica");
        }
    }
}