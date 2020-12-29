using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Isaac";
            cliente.CPF = "123.456.789.00";
            cliente.Profissao = "Desenvolvedor de software";


            try
            {
                ContaCorrente conta = new ContaCorrente(467, 86712540);
                conta.Titular = cliente;
                Console.WriteLine("Titular: " + conta.Titular.Nome);
                Console.WriteLine("Agencia: " + conta.Agencia);
                Console.WriteLine("Conta: " + conta.Numero);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("O argumento com problema é: " + e.ParamName);
                Console.WriteLine("Aconteceu uma exceção do tipo ArgumentException.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine();
            //Console.WriteLine("Taxa de operação: " + ContaCorrente.TaxaOprecacao);


            Console.ReadLine();
        }
    }
}
