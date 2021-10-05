﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        //método de extensão genérico
        public static void AdicionarVarios<T>(this List<T> lista, params T[] items)
        {
            foreach (T item in items)
            {
                lista.Add(item);
            }
        }
    }
}
