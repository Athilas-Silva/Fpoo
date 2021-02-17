namespace Aula_38_08_02_21
{
    public class TestaCarro
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro();

            //Atributos da classe base/pai (meiosTransporte)
            car1.Marca = "Chevrolet";
            car1.Modelo = "Camaro";
            car1.AnoFabricacao = 2020;
            car1.Combustivel = "Gasolina";
            car1.numPassageiros = 2;

            //Atributos da calsse filho
            car1.Aro = 17;
            car1.Suspensao = "Esportivo";
            car1.Kilometragem = 0;

            System.Console.WriteLine("Marca: " + car1.Marca);
            System.Console.WriteLine("Modelo: " + car1.Modelo);
            System.Console.WriteLine("Ano de Fabricação: " + car1.AnoFabricacao);
            System.Console.WriteLine("Combustivel: " + car1.Combustivel);
            System.Console.WriteLine("Número de Passageiros: " + car1.numPassageiros);
            System.Console.WriteLine("Aro da Roda: " + car1.Aro);
            System.Console.WriteLine("Suspensão: " + car1.Suspensao);
            System.Console.WriteLine("Kilometragem: " + car1.Kilometragem);
        }
    }
}