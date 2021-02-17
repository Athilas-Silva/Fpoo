namespace Classes_Abstratas
{
    public class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public static double valeRefeicaoDiario { get; set; }

        //Método de Instancia
        public void AumentarSalario(double aumento){
            this.salario += aumento;
        }

        //Método de classe - Não necessita de instancia
        public static void ReajustarValeRefeicaoDiario(double taxa){
            Funcionario.valeRefeicaoDiario += Funcionario.valeRefeicaoDiario * taxa;
        }
    }
}