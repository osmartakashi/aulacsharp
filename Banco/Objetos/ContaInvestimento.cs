﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Repositorios;

namespace Banco.Objetos
{
    public class ContaInvestimento : IConta, ITributavel
    {
        //public override void EfetuarDeposito(decimal valor)
        //{
        //    Saldo -= valor * 0.25m / 100;
        //    Saldo += valor;
        //}

        //public override decimal EfetuarSaque(decimal valor)
        //{
        //    Saldo -= 1.50m;
        //    Saldo -= valor * 0.25m / 100;
        //    Saldo -= valor;
        //    return Saldo;
        //}
        private IBancoRepositorio _repositorio;

        public ContaInvestimento()
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
            Saldo -= 1.50m;
            Saldo -= CalcularTributo(valor);
            Saldo -= valor;
            return Saldo;
        }

        public decimal CalcularTributo(decimal valor)
        {
            return  valor * 0.25m / 100;
        }
    }
}
