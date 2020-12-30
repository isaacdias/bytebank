using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOprecacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
        

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("A agencia deve ser maior que zero.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O numero deve ser maior que zero.", nameof(numero));
            }


            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOprecacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if(_saldo < valor)
            {
                throw new SaldoInsuficienteException("Sado insuficiente para o saque no valor de " + valor);
            }
            _saldo-= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}
