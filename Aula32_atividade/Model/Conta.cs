namespace Aula_32___Tarefas
{
    public class Conta
    {
        public int numero { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }

        //Adicionando Métodos

        public void Deposita(double valor){
            this.saldo += valor;
        }

        public void Saca(double valor){
            this.saldo -= valor;
        }

        public void ImprimeExtrato(){
            System.Console.WriteLine("Saldo: " + this.saldo);
        }
        public double ConsultaSaldoDisponivel(){
            return this.saldo + this.limite;
        }
    }
}