namespace Aula_39_09_02_21
{
    public class Telefonista : Funcionario
    {
        public int EstacaoDeTrabalho { get; set; }

        public override void MostraDados()
        {
            base.MostraDados();
            System.Console.WriteLine("Estação de Trabalho: " + this.EstacaoDeTrabalho);
            System.Console.WriteLine("Bonificação: " + this.CalcularBonificacao());
        }
    }
}