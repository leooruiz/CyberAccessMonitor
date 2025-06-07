using System.Collections.Generic;
using System.Windows;
using CyberAccessMonitor.Models;

namespace CyberAccessMonitor
{
    public partial class HistoricoWindow : Window
    {
        public HistoricoWindow(List<Evento> eventos)
        {
            InitializeComponent();
            ListaEventos.ItemsSource = eventos;
        }
    }
}
