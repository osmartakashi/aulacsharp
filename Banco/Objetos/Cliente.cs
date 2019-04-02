using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Objetos
{
    class Cliente
    {
        public long IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        public void CadastrarNovo(Cliente cliente)
        {

        }

        public void AlterarCadastro(Cliente cliente)
        {

        }

        public void Excluir(Cliente cliente)
        {

        }
    }
}
