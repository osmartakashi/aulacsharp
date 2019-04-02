namespace Banco.Objetos
{
    /// <summary>
    /// exemplo de classe abstrata. Pode funcionar no lugar das interfaces caso queira alguma implementação padrão em algum método
    /// </summary>
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public virtual decimal VerificarSaldo()
        {
            return Saldo;
        }
        public abstract void EfetuarDeposito(decimal valor);
        public abstract decimal EfetuarSaque(decimal valor);
    }
    //public sealed class Conta
    //{

    //    protected decimal Saldo { get; set; }

    //    public  decimal VerificarSaldo()
    //    {
    //        return Saldo;
    //    }
    //    //métodos virtuals podem ser sobrescritos nas classes filhas com o uso da palavra chave override
    //    public  void EfetuarDeposito(decimal valor)
    //    {
    //        Saldo += valor;
    //    }

    //    public  decimal EfetuarSaque(decimal valor)
    //    {
    //        Saldo -= valor;
    //        return valor;
    //    }

    //}
}
