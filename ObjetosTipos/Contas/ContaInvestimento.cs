using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTipos.Contas
{
    public class ContaInvestimento : Conta
    {
        protected decimal SaldoContaInvestimento { get; set; }
        public override decimal EfetuarSaque(decimal valorSolicitado)
        {
            SaldoContaInvestimento -= valorSolicitado;
            return valorSolicitado;
        }

        public override decimal Depositar(decimal valorDeposito)
        {
            SaldoContaInvestimento += valorDeposito;
            return valorDeposito;
        }

        public override decimal ObterSaldo()
        {
            return SaldoContaInvestimento;
        }
    }
}
