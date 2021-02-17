using System;

namespace Aulas36_01_02_21
{
    public class TestaPessoa
    {
        static void Main(string[] args){

            //Vamos criar uma variavel de instancia da calsse Pessoa
            Pessoa p = new Pessoa();

            p.nome = "Pessoa Aleatória";
            p.idade = 20;
            p.rg = "12345678910";

            System.Console.WriteLine("Nome: " + p.nome);
            System.Console.WriteLine("Idade: " + p.idade);
            System.Console.WriteLine("RG: " + p.rg);
            p.Andar();
        }
    }
}