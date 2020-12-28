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

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            conta.titular = cliente;
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Titular: " + conta.titular.Nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.ReadLine();
        }
    }
}
