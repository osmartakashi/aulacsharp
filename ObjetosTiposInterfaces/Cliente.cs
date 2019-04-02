using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTiposInterfaces.Interfaces;

namespace ObjetosTiposInterfaces
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cnpj { get; set; }
        private IConta _conta;

        public Cliente(IConta conta)
        {
            _conta = conta;
        }

        public decimal ObterSaldo()
        {
            return _conta.ObterSaldo();
        }
    }
}
