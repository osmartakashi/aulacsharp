using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Objetos;
using Banco.Repositorios;

namespace Banco.Gestores
{
    public class GestorConta
    {
        private IBancoRepositorio _repositorio;
        public GestorConta()
        {
            _repositorio = new BancoRepositorio();
        }
        public void AddNovaConta(IConta conta)
        {
            _repositorio.CadastrarConta(conta);
        }

        public IConta ObterConta(long idConta)
        {
            return _repositorio.ObterConta(idConta);
        }
    }
}
