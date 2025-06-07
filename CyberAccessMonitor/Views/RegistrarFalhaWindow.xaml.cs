using CyberAccessMonitor.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CyberAccessMonitor
{
    public partial class RegistrarFalhaWindow : Window
    {
        public Evento EventoRegistrado { get; private set; }

        public RegistrarFalhaWindow()
        {

            InitializeComponent();
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string tipo = (TipoComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
                string descricao = DescricaoBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(descricao))
                    throw new ArgumentException("Todos os campos são obrigatórios.");

                Evento novaFalha = new Evento
                {
                    DataHora = DateTime.Now,
                    Tipo = tipo,
                    Descricao = descricao
                };

                MessageBox.Show("Falha registrada com sucesso!");

                EventoRegistrado = novaFalha;


                this.Close();
            }
            catch (Exception ex)
            {
                MensagemErro.Text = ex.Message;
            }
        }
    }
}
