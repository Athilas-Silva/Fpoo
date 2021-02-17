namespace Aula_38_08_02_21
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string dtNascimento { get; set; }
        //Atributos da classe

        public void Comer( string tipo){
            System.Console.WriteLine("A pessoa" + tipo + " comeu!!!");
            //Método da Classe
        }
    }
}