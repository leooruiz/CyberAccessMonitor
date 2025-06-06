using CyberAccessMonitor.Services;
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


namespace CyberAccessMonitor
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Password;

            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Usuário e senha são obrigatórios.");
                }

                if (username == "admin" && password == "1234")
                {
                    DashboardWindow dashboard = new DashboardWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    throw new UnauthorizedAccessException("Credenciais inválidas.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                LogService.Registrar(exception.Message, "Login");
            }
        }
    }
}

