using System;
using System.Collections.Generic;
using System.IO;
using CyberAccessMonitor.Models;
using Newtonsoft.Json;
namespace CyberAccessMonitor.Services
{
    public static class SyncService
    {
        public static void ExportarEventos(List<Evento> eventos, string caminhoArquivo)
        {
            try
            {
                string json = JsonConvert.SerializeObject(eventos, Formatting.Indented);
                File.WriteAllText(caminhoArquivo, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao exportar dados: {ex.Message}");
            }
        }
    }
}

