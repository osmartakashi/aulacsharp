using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Objetos;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //var contaInvestimento = new ContaInvestimento();
            //var contaPoupanca = new ContaPoupanca();
            //var contaCorrente = new ContaCorrente();
            IConta contaCorrente = new ContaCorrente();

            contaCorrente.EfetuarDeposito(100);
            
            //var saldo = conta.VerificarSaldo();
            //conta.EfetuarDeposito(1000);
            //var vlrSaque = conta.EfetuarSaque(100);
            Console.Read();

        }
    }
}
