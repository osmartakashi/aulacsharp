using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Objetos;

namespace Banco.Repositorios
{
    public class BancoRepositorio : IBancoRepositorio
    {

        public void CadastrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void CadastrarConta(IConta conta)
        {
            throw new NotImplementedException();
        }

        public decimal ObterSaldo(long idConta)
        {
            throw new NotImplementedException();
        }

        public decimal Depositar(IConta conta)
        {
            throw new NotImplementedException();
        }

        public decimal EfetuarSaque(IConta conta)
        {
            throw new NotImplementedException();
        }

        public IConta ObterConta(long idCliente)
        {
            throw new NotImplementedException();
        }
    }
}
