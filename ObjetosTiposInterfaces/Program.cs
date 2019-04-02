using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTiposInterfaces.Contas;

namespace ObjetosTiposInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente(new ContaPoupanca());

            var saldo = cliente.ObterSaldo();

        }
    }
}
