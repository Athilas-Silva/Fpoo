namespace Aula_38_08_02_21
{
    public class TestaProduto
    {
        static void Main(string[] args)
        {
            Produto[] vetProduto = new Produto[2];

            System.Console.WriteLine("Dados dos Produtos");
            System.Console.WriteLine("----------------------");

            for (int i = 0; i < vetProduto.Length; i++)
            {
                vetProduto[i] = new Produto();

                System.Console.WriteLine("Digite a Marca: ");
                vetProduto[i].Marca = System.Console.ReadLine();

                System.Console.WriteLine("Digite o Modelo: ");
                vetProduto[i].Modelo = System.Console.ReadLine();

                System.Console.WriteLine("Digite o Preço: ");
                vetProduto[i].Preco = System.Console.ReadLine();
            }

            foreach (Produto prod in vetProduto)
            {
                System.Console.WriteLine("Marca: " + prod.Marca + "\tModelo: " + prod.Modelo + "\tPreço: " + prod.Preco);
            }
        }
    }
}