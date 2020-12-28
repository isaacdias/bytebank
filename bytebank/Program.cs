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
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Isaac";
            conta.agencia = 123;
            conta.conta = 456789;
            conta.saLdo = 100;


            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.conta);
            Console.WriteLine(conta.saLdo);
            Console.ReadLine();
        }
    }
}
