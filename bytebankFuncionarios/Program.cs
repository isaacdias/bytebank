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
            Funcionario carlos = new Funcionario(2000, "123.456.789.20");
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);
            carlos.AumentarSalario();
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine("Novo salario de Carlos é: " + carlos.Salario);

            Diretor roberta = new Diretor("789.456.123.79");

            roberta.Nome = "Roberta";
            gerenciador.Registrar(roberta);
            roberta.AumentarSalario();


            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine("Novo salario de Carlos é: " + roberta.Salario);


            Console.WriteLine("Total de bonificações: " +  gerenciador.getTotalBonificacao());
            
            Console.ReadLine();
        }
    }
}
