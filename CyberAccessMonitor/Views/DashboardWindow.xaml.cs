using CyberAccessMonitor.Models;
using CyberAccessMonitor.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;


namespace CyberAccessMonitor
{
    public partial class DashboardWindow : Window
    {
        private readonly List<Evento> eventos = new List<Evento>();

        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void RegistrarFalha_Click(object sender, RoutedEventArgs e)
        {
            var janela = new RegistrarFalhaWindow();
            janela.ShowDialog();

            if (janela.EventoRegistrado != null)
                eventos.Add(janela.EventoRegistrado);
        }



        private void Historico_Click(object sender, RoutedEventArgs e)
        {
            var janela = new HistoricoWindow(eventos);
            janela.ShowDialog();
        }


        private void Alerta_Click(object sender, RoutedEventArgs e)
        {
            AlertaWindow alerta = new AlertaWindow();
            alerta.ShowDialog();

            eventos.Add(new Models.Evento
            {
                DataHora = DateTime.Now,
                Tipo = "Alerta Manual",
                Descricao = "Alerta de segurança acionado manualmente"
            });
        }



        private void Exportar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                    FileName = "eventos_exportados.json",
                    Filter = "JSON files (*.json)|*.json"
                };

                if (dialog.ShowDialog() == true)
                {
                    SyncService.ExportarEventos(eventos, dialog.FileName);
                    MessageBox.Show("Exportação realizada com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                LogService.Registrar(ex.Message, "Exportação");
            }
        }


        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
