using System;

namespace Ex.Complementar
{
    public class ControleDePonto
    {
        public void RegistrarEntrada(Funcionario f){
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy  HH:mm:ss}", agora);

            System.Console.WriteLine("Entrada: " + f.Codigo);
            System.Console.WriteLine("Data: " + horario);
        }

        public void RegistrarSaida(Funcionario f){
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy  HH:mm:ss}", agora);

            System.Console.WriteLine("Saida: " + f.Codigo);
            System.Console.WriteLine("Data: " + horario);
        }
    }
}