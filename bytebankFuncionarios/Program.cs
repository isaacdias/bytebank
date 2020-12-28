using bytebankFuncionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario("123.456.789.20");
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor("789.456.123.79");

            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);


            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " +  gerenciador.getTotalBonificacao());
            
            Console.ReadLine();
        }
    }
}
