using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Repositorios;

namespace Banco.Objetos
{
    public class ContaCorrente : IConta, ITributavel
    {
        //public override void EfetuarDeposito(decimal valor)
        //{
        //    Saldo -= valor * 0.25m / 100;
        //    base.EfetuarDeposito(valor);
        //}

        //public override decimal EfetuarSaque(decimal valor)
        //{
        //    Saldo -= 2;
        //    Saldo -= valor * 0.25m / 100;
        //    base.EfetuarSaque(valor);
        //    return valor;
        //}
        //public override void EfetuarDeposito(decimal valor)
        //{
        //    Saldo -= valor * 0.25m / 100;
        //    Saldo += valor;
        //}

        //public override decimal EfetuarSaque(decimal valor)
        //{
        //    Saldo -= 2;
        //    Saldo -= valor * 0.25m / 100;
        //    Saldo -= valor;
        //    return valor;
        //}
        private IBancoRepositorio _repositorio;

        public ContaCorrente()
        {
            _repositorio = new BancoRepositorio();
        }
        public long IdConta { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string NumeroConta { get; set; }
        public Cliente cliente { get; set; }

        public decimal VerificarSaldo()
        {
            return Saldo;
        }

        public void EfetuarDeposito(decimal valor)
        {
            Saldo -= CalcularTributo(valor);
            Saldo += valor;
        }

        public decimal EfetuarSaque(decimal valor)
        {
            Saldo -= 2;
            Saldo -= CalcularTributo(valor);
            Saldo -= valor;
            return valor;
        }

        public decimal CalcularTributo(decimal valor)
        {
            return valor * 0.25m / 100;
        }
    }
}
