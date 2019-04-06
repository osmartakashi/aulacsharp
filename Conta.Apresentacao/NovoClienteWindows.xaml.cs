using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Banco.Gestores;
using Banco.Objetos;

namespace Conta.Apresentacao
{
    /// <summary>
    /// Interaction logic for NovoClienteWindows.xaml
    /// </summary>
    public partial class NovoClienteWindows : Window
    {
        private GestorConta gestorConta;
        public NovoClienteWindows()
        {
            gestorConta = new GestorConta();
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var cliente = new Cliente();
            cliente.Cpf = this.txtCpf.Text;
            cliente.Nome = this.txtNome.Text;
            cliente.Sobrenome = this.txtSobrenome.Text;
            cliente.DataNascimento = this.txtDtNascimento.DisplayDate;
            cliente.Rg = this.txtRg.Text;
            
            var tipoConta = this.cbbTipoConta.Text as string;
            IConta conta = null;
            switch (tipoConta)
            {
                case "Conta Corrente":
                     conta = new ContaCorrente();
                    conta.cliente = cliente;
                     var ramdom = new Random();
                     conta.DataAbertura = DateTime.Now;
                     conta.NumeroConta = ramdom.Next(1, 100).ToString();
                     conta.DataEncerramento = null;
                     conta.Saldo = Convert.ToDecimal(this.txtDepositoInicial.Text);
                    break;
                case "Conta Poupança":
                     conta = new ContaPoupanca();
                    conta.cliente = cliente;
                    break;
                case "Conta Investimento":
                     conta = new ContaInvestimento();
                    conta.cliente = cliente;
                    break;
            }

            try
            {
                gestorConta.AddNovaConta(conta);
                MessageBox.Show("Cliente salvo com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o cliente");
                
            }
          

            
        }

    }
}
