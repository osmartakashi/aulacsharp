using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Repositorios;

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
        private IBancoRepositorio _repositorio;

        public ContaPoupanca()
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
            return _repositorio.ObterSaldo(IdConta);
        }

        public void EfetuarDeposito(decimal valor)
        {
            Saldo += valor;
            _repositorio.Depositar(this);
        }

        public decimal EfetuarSaque(decimal valor)
        {
            Saldo -= valor;
            _repositorio.EfetuarSaque(this);
            return valor;
        }
    }
}
