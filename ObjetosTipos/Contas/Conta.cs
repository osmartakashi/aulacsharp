namespace ObjetosTipos.Contas
{
    public class Conta
    {
        //field privado
        private string _numeroConta;
        public TipoConta TipoConta;

        //getter
        public string GetNumeroConta()
        {
            return _numeroConta;
        }
        //setter
        public void SetNumeroConta(string numeroConta)
        {
            _numeroConta = numeroConta;
        }

        //propriedade encapsulando o fied privado
        public string NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }

        //propriedade auto implementada, ela cria automaticamente um campo privado debaixo dos panos
       // public string NumeroConta { get; set; }
       protected decimal Saldo { get; set; }
       //protected decimal SaldoPoupanca { get; set; }
       //protected decimal SaldoInvestimento { get; set; }

       //public virtual decimal EfetuarSaque(decimal valorSolicitado, TipoConta tipoConta)
       //{
       //    if (tipoConta == TipoConta.ContaCorrente)
       //    {
       //        Saldo = Saldo - valorSolicitado - 0.10m;
       //        return valorSolicitado;
       //     }
       //    //else if(tipoConta == TipoConta.ContaPoupanca)
       //    //{
       //    //    SaldoPoupanca = SaldoPoupanca - valorSolicitado;
       //    //    return valorSolicitado;
       //    //}
       //    else
       //    {
       //        SaldoInvestimento = SaldoInvestimento - valorSolicitado - 1.00m;
       //        return valorSolicitado;
       //    }
           
       //}

       public virtual decimal EfetuarSaque(decimal valorSolicitado)
       {
           Saldo -= valorSolicitado;
           return valorSolicitado;
       }

       public virtual decimal ObterSaldo()
       {
           return Saldo;
       }

       //public virtual decimal Depositar(decimal valorDeposito, TipoConta tipoConta)
       //{
       //    //if (tipoConta == TipoConta.ContaCorrente)
       //    //{
       //    //    Saldo = Saldo + valorDeposito - 0.10m;
       //    //    return Saldo;
       //    //}
       //    //else if(tipoConta == TipoConta.ContaPoupanca)
       //    //{
       //    //    SaldoPoupanca = SaldoPoupanca + valorDeposito;
       //    //    return SaldoPoupanca;
       //    // }
       //    //else
       //    //{
       //    //    SaldoInvestimento = SaldoInvestimento + valorDeposito;
       //    //    return SaldoInvestimento;
       //    //}
 
       //}

       public virtual decimal Depositar(decimal valorDeposito)
       {
           Saldo += valorDeposito;
           return Saldo;
       }

    }

    public enum TipoConta
    {
        ContaCorrente,
        ContaPoupanca,
        Investimento
    }
}
