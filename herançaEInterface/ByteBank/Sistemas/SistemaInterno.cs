﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autenticavel, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Logado no Sistema Interno.");
                return true;
            } else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}
