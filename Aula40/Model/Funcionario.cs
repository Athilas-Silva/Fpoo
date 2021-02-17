namespace Aula_39_09_02_21
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalcularBonificacao(){
            return this.Salario * 0.1;
        }

        public virtual void MostraDados(){
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Salário: " + this.Salario);
            System.Console.WriteLine("Bonificação: " + this.CalcularBonificacao());
        }
    }
}