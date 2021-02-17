namespace Aula_32___19_01_21
{
    public class Conta
    {
        public int numeroConta { get; set; }
        public double saldo { get; set; }
        public double limite = 100;
        public Agencia agencia { get; set; }
        public Conta(Agencia agencia){
            this.agencia = agencia;
        }

        public void Transfere(Conta destino, double valor){
            this.saldo -= valor;
            destino.saldo += valor;
        }

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