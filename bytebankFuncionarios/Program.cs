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
            Console.WriteLine("O total de funcionários cadastrados é: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("O salário do carlos é :" + carlos.Salario);
            Console.WriteLine("A bonificação do Carlos é: " + carlos.GetBonificacao());
            carlos.AumentarSalario();
            Console.WriteLine("O Novo salario de Carlos é: " + carlos.Salario);
            Console.WriteLine();

            Diretor roberta = new Diretor("789.456.123.79");

            roberta.Nome = "Roberta";
            gerenciador.Registrar(roberta);
            Console.WriteLine("O total de funcionários cadastrados é: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine(roberta.Nome);
            Console.WriteLine("O salário da Roberta é :" + roberta.Salario);
            Console.WriteLine("A bonificação da Roberta é: " + roberta.GetBonificacao());
            roberta.AumentarSalario();
            Console.WriteLine("Novo salario da Roberta é: " + roberta.Salario);
            Console.WriteLine();
            Console.WriteLine("Total de bonificações: " +  gerenciador.getTotalBonificacao());

            Console.ReadLine();
        }
    }
}
