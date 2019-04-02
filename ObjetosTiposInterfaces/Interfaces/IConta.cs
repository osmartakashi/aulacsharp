using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTiposInterfaces.Interfaces
{
    public interface IConta
    {
         decimal Saldo { get; set; }
         decimal Sacar(decimal valorSaque);
         decimal Depositar(decimal valorDeposito);
         decimal ObterSaldo();

    }
}
