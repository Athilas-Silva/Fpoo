namespace Aula_39_09_02_21
{
    public class Secretaria : Funcionario
    {
        public int Ramal { get; set; }

        public override void MostraDados()
        {
            base.MostraDados();
            System.Console.WriteLine("Ramal: " + this.Ramal);
            System.Console.WriteLine("Bonificação: " + this.CalcularBonificacao());
        }
    }
}