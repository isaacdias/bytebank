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
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789-00");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("789.456.123.11");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("456.123.789.22");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("123.789.456.33");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.getTotalBonificacao());
        }
    }
}
