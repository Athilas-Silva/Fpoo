namespace Aula_31___14_01_21
{
    public class TestaTurma
    {
        static void Main(string[] args)
        {
            Turma t1 = new Turma();
            t1.periodo = "Tarde";
            t1.serie = "Sexta-Série";
            t1.sigla = "C";
            t1.ensino = "Ensino Fundamental";

            Turma t2 = new Turma();
            t2.periodo = "Noite";
            t2.serie = "Terceiro Ano";
            t2.sigla = "A";
            t2.ensino = "Ensino Médio";


            System.Console.WriteLine("Dados da primeira Turma");
            System.Console.WriteLine("Periodo: " + t1.periodo);
            System.Console.WriteLine("Série: " + t1.serie);
            System.Console.WriteLine("Sigla: " + t1.sigla);
            System.Console.WriteLine("Ensino: " + t1.ensino);

            System.Console.WriteLine("\nDados da segunda Turma");
            System.Console.WriteLine("Periodo: " + t2.periodo);
            System.Console.WriteLine("Série: " + t2.serie);
            System.Console.WriteLine("Sigla: " + t2.sigla);
            System.Console.WriteLine("Ensino: " + t2.ensino);
        }
    }
}