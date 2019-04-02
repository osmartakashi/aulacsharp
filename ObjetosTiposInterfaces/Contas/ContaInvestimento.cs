using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTiposInterfaces.Interfaces;

namespace ObjetosTiposInterfaces.Contas
{
    class ContaInvestimento : IConta
    {
        public decimal Saldo { get; set; }
        public decimal Sacar(decimal valorSaque)
        {
            throw new NotImplementedException();
        }

        public decimal Depositar(decimal valorDeposito)
        {
            throw new NotImplementedException();
        }

        public decimal ObterSaldo()
        {
            throw new NotImplementedException();
        }
    }
}
