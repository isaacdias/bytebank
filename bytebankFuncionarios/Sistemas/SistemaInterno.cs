using bytebankFuncionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankFuncionarios.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
