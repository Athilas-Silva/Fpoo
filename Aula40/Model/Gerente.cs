namespace Aula_39_09_02_21
{
    public class Gerente : Funcionario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public override double CalcularBonificacao(){
            return this.Salario * 0.6 + 100;
        }

        public override void MostraDados(){
            base.MostraDados();
            System.Console.WriteLine("Usuário: " + this.Usuario);
            System.Console.WriteLine("Senha: " + this.Senha);
            System.Console.WriteLine("Bonificação: " + CalcularBonificacao());
        }
    }
}