using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Objetos;

namespace Banco.Repositorios
{
    public interface IBancoRepositorio
    {
        void CadastrarCliente(Cliente cliente);
        void CadastrarConta(IConta conta);
        decimal ObterSaldo(long idConta);
        decimal Depositar(IConta conta);
        decimal EfetuarSaque(IConta conta);
        IConta ObterConta(long idCliente);
    }
}
