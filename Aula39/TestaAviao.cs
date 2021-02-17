namespace Aula_38_08_02_21
{
    public class TestaAviao
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao();
            //Atributos da classe base/pai (meiosTransporte)
            a1.Marca = "Airbus";
            a1.Modelo = "A360";
            a1.AnoFabricacao = 2020;
            a1.Combustivel = "Querosene de avião";
            a1.numPassageiros = 868;
            
            //Atributos da classe filho
            a1.Tipo = "Comercial";
            a1.Autonomia = 15;
            a1.horasVoo = 150000;

            System.Console.WriteLine("Marca: " + a1.Marca);
            System.Console.WriteLine("Modelo: " + a1.Modelo);
            System.Console.WriteLine("Ano de Fabricação: " + a1.AnoFabricacao);
            System.Console.WriteLine("Combustivel: " + a1.Combustivel);
            System.Console.WriteLine("Número de Passageiros: " + a1.numPassageiros);
            System.Console.WriteLine("Tipo do avião: " + a1.Tipo);
            System.Console.WriteLine("Autonomia do avião: " + a1.Autonomia);
            System.Console.WriteLine("Horas de Voo: " + a1.horasVoo);
        }
    }
}