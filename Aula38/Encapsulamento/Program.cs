using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            
            f.Nome = "Son Goku";
            f.Salario = 2000;

            System.Console.WriteLine(f.Nome);
            System.Console.WriteLine(f.Salario);
        }
    }
}
