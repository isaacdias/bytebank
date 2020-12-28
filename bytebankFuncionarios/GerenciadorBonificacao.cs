using bytebankFuncionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankFuncionarios
{
    public class GerenciadorBonificacao
    {
        private double _totalBonitifacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonitifacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            _totalBonitifacao += diretor.GetBonificacao();
        }

        public double getTotalBonificacao()
        {
            return _totalBonitifacao;
        }
    }
}
