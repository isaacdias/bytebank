using bytebankFuncionarios.Funcionarios;
using bytebankFuncionarios.Sistemas;
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
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("789.456.123.11");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("123.789.456.33");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario isaac = new Desenvolvedor("654.321.987.44");
            isaac.Nome = "Isaac";

            Funcionario pedro = new Designer("123.456.789-00");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("789.456.123.11");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("456.123.789.22");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("123.789.456.33");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(isaac);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.getTotalBonificacao());
        }
    }
}
