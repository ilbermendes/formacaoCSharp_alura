using System;
using ByteBank.Exceptions;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesInvalidos { get; private set; }
        public int ContadorTransferenciasInvalidas { get; private set; }
        
        public int NumeroConta { get; } //automaticamente cria um campo privado somente leitura

        public int NumeroAgencia { get; }

        private double _saldo = 0;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
           if (numeroAgencia <= 0)
            {
                throw new ArgumentException("Número da Agência deve ser maior do que zero.", nameof(numeroAgencia));
            }
           if (numeroConta <= 0)
            {
                throw new ArgumentException("Número da Conta deve ser maior do que zero.", nameof(numeroConta));
            }

            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }


        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesInvalidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException e)
            {
                ContadorTransferenciasInvalidas++;
                throw new OperacaoFinanceiraException("Transferência inválida.", e);
            }
            contaDestino.Depositar(valor);
        }
    }
}
