using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Objetos;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using Dapper;

namespace Banco.Repositorios
{
    public class BancoRepositorio : IBancoRepositorio
    {
        private string _connString;
        public BancoRepositorio()
        {
            _connString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;
        }
        public void CadastrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void CadastrarConta(IConta conta)
        {
            var insertUsuario = @"
INSERT INTO [dbo].[Cliente]
           ([Nome]
           ,[Sobrenome]
           ,[Cpf]
           ,[Rg]
           ,[DataNascimento])
     VALUES
           (@nome
           ,@sobrenome
           ,@cpf
           ,@rg
           ,@dataNascimento)

select scope_identity()

";
            var insertConta = @"
INSERT INTO [dbo].[Conta]
           ([IdCliente]
           ,[DataAbertura]
           ,[DataEncerramento]
           ,[Saldo]
           ,[TipoConta]
           ,[NumeroConta])
     VALUES
           (@idCliente,
           ,@dataAbertura
           ,@dataEncerramento
           ,@saldo
           ,@tipoConta
           ,@numeroConta)

";
            try
            {
                using (var tr = new TransactionScope())
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    long idUsuario = conn.Query<long>(insertUsuario, conta.cliente).FirstOrDefault();
                    conta.IdCliente = idUsuario;
                    conn.Execute(insertConta, conta);
                    tr.Complete();
                }
            }
            catch (SqlException)
            {
                //Logar no application insight
                //tratar excessao aqui
            }
            catch (Exception e)
            {
                //tratar excessao aqui
            }
        }

        public decimal ObterSaldo(long idConta)
        {
            try
            {
                var sql = @"select Saldo from Conta where IdConta = @idConta";
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                   return conn.Query<decimal>(sql, idConta).FirstOrDefault();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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
