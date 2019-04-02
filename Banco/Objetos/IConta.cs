using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Objetos
{
    /// <summary>
    /// Interface para os tipos ContaCorrente, ContaPoupanca e ContaInvestimento.
    /// Todas as classes que forem algum tipo de conta deverão implementar a mesma interface.
    /// </summary>
    public interface IConta
    {
        decimal Saldo { get; set; }
        DateTime DataAbertura { get; set; }
        DateTime DataEncerramento { get; set; }
        string NumeroConta { get; set; }

        decimal VerificarSaldo();

        void EfetuarDeposito(decimal valor);

        decimal EfetuarSaque(decimal valor);
    }
}
