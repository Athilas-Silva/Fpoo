namespace Aula_40_10_02_21
{
    public class TestaGeradorDeExtrato
    {
        static void Main(string[] args)
        {
            GeradorDeExtrato gerador = new GeradorDeExtrato();

            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 2000;

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 1000;

            gerador.ImprimeExtratoBasico(cp);
            gerador.ImprimeExtratoBasico(cc);
        }
    }
}