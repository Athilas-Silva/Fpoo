namespace Ex.Complementar
{
    public class TestaControleDePonto
    {
        static void Main(string[] args)
        {
            ControleDePonto controle = new ControleDePonto();

            Gerente g = new Gerente();
            g.Codigo = 12345;

            Telefonista t = new Telefonista();
            t.Codigo = 67890;

            controle.RegistrarEntrada(g);
            controle.RegistrarSaida(g);

            System.Console.WriteLine("**********************");

            controle.RegistrarEntrada(t);
            controle.RegistrarSaida(t);
        }
    }
}