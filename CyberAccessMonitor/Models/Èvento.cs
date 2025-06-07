using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAccessMonitor.Models
{
    public class Evento
    {
        public DateTime DataHora { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
