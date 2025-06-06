using System;
using System.IO;

namespace CyberAccessMonitor.Services
{
    public static class LogService
    {
        private static readonly string logPath = "logs";

        public static void Registrar(string mensagem, string origem = "Sistema")
        {
            try
            {
                if (!Directory.Exists(logPath))
                    Directory.CreateDirectory(logPath);

                string nomeArquivo = $"log_{DateTime.Now:yyyyMMdd}.txt";
                string caminhoCompleto = Path.Combine(logPath, nomeArquivo);

                string linha = $"[{DateTime.Now:HH:mm:ss}] ({origem}) {mensagem}{Environment.NewLine}";
                File.AppendAllText(caminhoCompleto, linha);
            }
            catch
            {
                // Falha silenciosa: não queremos travar o app por erro de log
            }
        }
    }
}
