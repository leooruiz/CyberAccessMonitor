# 🔐 CyberAccessMonitor

Sistema desktop em C# (WPF) para simular respostas locais a falhas de energia e ameaças cibernéticas em condomínios residenciais. Desenvolvido como parte do projeto acadêmico de Impactos e Ameaças Cibernéticas.

---

Vídeo PITCH: https://youtu.be/rWAi3q4DCRU

## 🎯 Objetivo

Oferecer uma ferramenta simples e offline que permita:
- Registrar falhas elétricas locais
- Acionar alertas visuais
- Registrar logs internos
- Simular exportação de dados
- Analisar histórico de eventos

Tudo isso reforçando a **autonomia local de resposta a emergências**, mesmo sem conexão com a internet.

---

## 🖥️ Tecnologias Utilizadas

- C# com WPF (.NET Framework)
- Newtonsoft.Json (para serialização)
- System.IO (para arquivos e logs)
- Arquitetura em camadas (Views / Models / Services)

---

## ✅ Funcionalidades

| Funcionalidade            | Descrição |
|---------------------------|-----------|
| 🔐 Login obrigatório       | Validação com mensagens de erro e logs |
| 📝 Registro de falhas      | Captura tipo, descrição, data/hora |
| 📋 Histórico de eventos    | Exibe todas as falhas da sessão |
| 🚨 Alerta manual           | Exibe alerta visual com som e log |
| 📤 Exportação de dados     | Gera `.json` com os eventos salvos |
| 🧾 Log interno             | Registra ações e exceções em `.txt` |

---

## 🧪 Como Executar

1. Clone ou baixe este repositório
2. Abra o arquivo `.sln` no **Visual Studio (Windows)**
3. Compile e execute com F5
4. Use o login padrão:

Usuário: admin
Senha: 1234


---

## 📁 Estrutura de Pastas

CyberAccessMonitor/
├── Models/ # Entidades: Evento, etc.
├── Services/ # Lógicas de negócio: Log, Sync
├── Views/Windows # Telas: Login, Dashboard, etc.
├── logs/ # Logs diários automáticos
├── CyberAccessMonitor.sln


---

## 📎 Dependências NuGet

- `Newtonsoft.Json`  
> Usado para exportar dados em JSON

---

## 👤 Autor

- **Leonardo Ruiz** – RM 98901  
- **Bruno Venturi Lopes Vieira** – RM 99431  

Global Solution – FIAP | Engenharia de Software
---

## 🧠 Importância

A aplicação representa um protótipo de resposta comunitária a falhas energéticas com foco em **resiliência local, registro de incidentes e segurança da informação em tempos de instabilidade.**

---

