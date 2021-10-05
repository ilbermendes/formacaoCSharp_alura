//using  _08_ByteBank;

namespace _08_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int NumeroAgencia { get; set; }
        public int NumeroConta { get; set; }
        
        private double _saldo;
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
                } else
                {
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;

        }

  
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

