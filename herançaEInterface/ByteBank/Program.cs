using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcularBonifacoes();
            Console.WriteLine();
            usarSistema();

            Console.ReadLine();
        }

        public static void usarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diretor1 = new Diretor("123.456.789=10");
            diretor1.Senha = "123";

            GerenteDeConta gerenteDeConta1 = new GerenteDeConta("321.543.654.-70");
            gerenteDeConta1.Senha = "321";

            ParceiroComercial parceiroComercial1 = new ParceiroComercial();
            parceiroComercial1.Senha = "abc";

            sistemaInterno.Logar(diretor1, "123");
            sistemaInterno.Logar(gerenteDeConta1, "321");
            sistemaInterno.Logar(parceiroComercial1, "abc");
        }

        public static void CalcularBonifacoes()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Diretor diretor1 = new Diretor("123.456.789=10");
            GerenteDeConta gerenteDeConta1 = new GerenteDeConta("321.543.654.-70");
            Designer designer1 = new Designer("987.654.321.-34");
            Estagiario estagiario1 = new Estagiario("365.798.365-55");

            gerenciadorBonificacao.Registrar(diretor1);
            gerenciadorBonificacao.Registrar(gerenteDeConta1);
            gerenciadorBonificacao.Registrar(designer1);
            gerenciadorBonificacao.Registrar(estagiario1);

            Console.WriteLine("Total em bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
