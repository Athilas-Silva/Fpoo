using System;

namespace Aula_40_10_02_21
{
    public class GeradorDeExtrato
    {
        public void ImprimeExtratoBasico(Conta c){
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/m/yyyy HH:mm:ss}", agora);

            System.Console.WriteLine("DATA: " + horario);
            System.Console.WriteLine("Saldo: " + c.Saldo);
        }
    }
}