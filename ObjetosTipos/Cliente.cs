using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTipos.Contas;

namespace ObjetosTipos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cnpj { get; set; }
        public Conta Conta { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public ContaInvestimento ContaInvestimento { get; set; }
    }
}
