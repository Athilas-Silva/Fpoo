namespace Aulas36_01_02_21
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string rg { get; set; }

        public void Andar(){
            System.Console.WriteLine("A pessoa andou!!!");
        }
    }
}