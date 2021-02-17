using System;

namespace Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            //atributos ou propriedades de instancia - func
            func.nome = "José da Silva";
            func.salario = 2000;

            //atributo de classe - nao necesita de instancia - static
            Funcionario.valeRefeicaoDiario = 25;

            System.Console.WriteLine("Nome: " + func.nome);
            System.Console.WriteLine("Salário antes do aumento: " + func.salario);
            System.Console.WriteLine("Vale refeição antes do aumento: " + Funcionario.valeRefeicaoDiario);

            //Passando o valor do aumento salário - 500
            func.AumentarSalario(500); //metodo de instancia

            //Passando a taxa de aumento do valeRefeicaoDiario - método de classe - static
            Funcionario.ReajustarValeRefeicaoDiario(0.1);

            System.Console.WriteLine("\nNome: " + func.nome);
            System.Console.WriteLine("Valor do vale refeição: " + Funcionario.valeRefeicaoDiario);
            System.Console.WriteLine("Salário depois do aumento: " + func.salario);
        }
    }
}
