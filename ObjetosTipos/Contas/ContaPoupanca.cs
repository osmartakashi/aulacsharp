using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTipos.Contas
{
    public class ContaPoupanca : Conta
    {
        protected decimal SaldoPoupanca { get; set; }

        public override decimal Depositar(decimal valorDeposito)
        {
            SaldoPoupanca += valorDeposito;
            return valorDeposito;
        }

        public override decimal EfetuarSaque(decimal valorSolicitado)
        {
            SaldoPoupanca -= valorSolicitado;
            return valorSolicitado;
        }

        public override decimal ObterSaldo()
        {
            return SaldoPoupanca;
        }
    }
}
