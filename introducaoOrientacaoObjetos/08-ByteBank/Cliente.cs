using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; } //ainda não existe uma lógica para implementar, pode ficar assim.

        private string _cpf;
        public string CPF {
            get 
            {
                return _cpf;
            }
            set 
            {
                //aqui vai a lógica do cpf...
                _cpf = value;
            } 
        }
    }
}
