using System.Windows;
using System.Media;

namespace CyberAccessMonitor
{
    public partial class AlertaWindow : Window
    {
        public AlertaWindow()
        {
            InitializeComponent();

            try
            {
                // Toca som padrão do Windows (ou adicione um .wav customizado)
                SystemSounds.Exclamation.Play();
            }
            catch
            {
                // Som opcional - falha não impacta
            }
        }
    }
}
