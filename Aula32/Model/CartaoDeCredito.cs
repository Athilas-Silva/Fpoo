namespace Aula_32___19_01_21
{
    public class CartaoDeCredito
    {
        public int numeroConta { get; set; }
        public string dataDeValidade { get; set; }
        public Cliente cliente { get; set; }

        public CartaoDeCredito(int numero){
            this.numeroConta = numeroConta;
        }
    }
}