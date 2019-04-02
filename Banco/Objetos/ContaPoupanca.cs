using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Objetos
{
    public class ContaPoupanca : IConta
    {
        //public override void EfetuarDeposito(decimal valor)
        //{
        //    Saldo += valor;
        //}

        //public override decimal EfetuarSaque(decimal valor)
        //{
        //    Saldo -= valor;
        //    return valor;
        //}        //public override void EfetuarDeposito(decimal valor)
        //{
        //    Saldo += valor;
        //}

        //public override decimal EfetuarSaque(decimal valor)
        //{
        //    Saldo -= valor;
        //    return valor;
        //}
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string NumeroConta { get; set; }

        public decimal VerificarSaldo()
        {
            return Saldo;
        }

        public void EfetuarDeposito(decimal valor)
        {
            Saldo += valor;
        }

        public decimal EfetuarSaque(decimal valor)
        {
            Saldo -= valor;
            return valor;
        }
    }
}
