using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            //Se x preceder y, retorna negativo
            //Se x e y forem equivalentes, retorna zero
            //Se y preceder x, retorna positivo

            if (x == y)
            {
                return 0;
            }
            
            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);

            //if (x.Agencia < y.Agencia)
            //{
            //    return -1;
            //}

            //if (x.Agencia == y.Agencia)
            //{
            //    return 0;
            //}

            //return 1;
        }
    }
}
