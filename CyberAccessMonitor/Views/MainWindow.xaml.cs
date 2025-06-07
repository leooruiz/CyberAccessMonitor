using CyberAccessMonitor.Services;
using System;
using System.Windows;
using System.Windows.Controls;


namespace CyberAccessMonitor
{
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

