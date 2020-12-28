using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankFuncionarios.Funcionarios
{
    public class Funcionario
    {       
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

             
        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
