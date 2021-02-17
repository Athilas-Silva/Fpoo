using System;

namespace CA_Estruturas
{
    class Program
    {
        public struct Data
        {
            public int dia, mes, ano;
                public Data(int objDia, int objMes, int objAno){
                this.dia = objDia;
                this.mes = objMes;
                this.ano = objAno;
            }
        }
        static void Main(string[] args)
        {
            //Instancio meu Struct, passando os parâmetros referentes ao dia , mês e ano e exibe ao usuário
            Data objDataHoje = new Data(28, 01, 2021);

            System.Console.WriteLine("\nData de hoje: " + objDataHoje.dia + "/" + objDataHoje.mes + "/" + objDataHoje.ano);

            //Atribuo a variável objDataHoje à variável objDataOntem, decremento o valor em 1 e exibindo ao usuário
            Data objDataOntem = objDataHoje;

            objDataOntem.dia--;

            Console.WriteLine("Data de ontem: " + objDataOntem.dia + "/" + objDataOntem.mes + "/" + objDataOntem.ano + "\n");

            //Atribuindo a variável objDataHoje à variável objAmanha, incremento o valor em 1 e exibindo ao usuário

            Data objAmanha = objDataHoje;

            objAmanha.dia++;

            Console.WriteLine("Data de Amanhã: " + objAmanha.dia + "/" + objAmanha.mes + "/" + objAmanha.ano + "\n");

            Console.ReadKey();
        }
    }
}
