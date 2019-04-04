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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Conta.Apresentacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItemClienteExistente_OnClick(object sender, RoutedEventArgs e)
        {
            var windowsCliExistente = new ClienteExistenteWindow();
            windowsCliExistente.WindowStartupLocation = this.WindowStartupLocation;
            windowsCliExistente.Show();
        }

        private void MenuItemNovoCliente_OnClick(object sender, RoutedEventArgs e)
        {
            var windowNovoCli = new NovoClienteWindows();
            windowNovoCli.WindowStartupLocation = this.WindowStartupLocation;
            windowNovoCli.Show();
        }
    }
}
