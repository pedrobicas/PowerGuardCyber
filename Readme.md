# Projeto – PowerGuardCyber - 
  
## 📌 Finalidade do Sistema 
  
O sistema **PowerGuardCyber** foi desenvolvido para monitorar falhas de energia e alertas de segurança relacionados a impactos cibernéticos em ambientes críticos. A aplicação visa simular cenários reais de vulnerabilidade quando há quedas de energia, permitindo o registro de eventos, alertas e a geração de relatórios. 
  
## Instruções de Execução 
  
1. **Pré-requisitos:** 
   - .NET SDK instalado (versão 6 ou superior). 
   - Visual Studio ou outro editor C# compatível. 
  
2. **Como rodar:** 
   - Clone o repositório: 
     ```bash 
     git clone https://github.com/pedrobicas/PowerGuardCyber.git
     ``` 
   - Navegue até a pasta do projeto: 
     ```bash 
     cd PowerGuardCyber 
     ``` 
   - Compile e execute: 
     ```bash 
     dotnet run 
     ``` 
  
3. **Uso básico:** 
   - Faça login simulado. 
   - Use o menu para registrar falhas, alertas, listar eventos, gerar relatórios e simular ataques cibernéticos. 
## 📦 Dependências 
O projeto PowerGuardCyber utiliza apenas dependências nativas do .NET. Abaixo estão os requisitos e versões mínimas recomendadas: 
- .NET SDK: versão 6.0 ou superior 
- IDE recomendada: Visual Studio 2022 ou superior (ou VS Code com extensão C#) 
- Sistema Operacional: Windows, Linux ou macOS (compatível com .NET) 
Nota: Este projeto não utiliza bibliotecas externas. Todos os recursos são implementados com bibliotecas padrão da linguagem C#. 
 
  
## 📂 Estrutura de Pastas 
  
PowerGuardCyber/ 
├── Program.cs 
├── GerenciadorEventos.cs 
├── Models/ 
│ ├── Evento.cs 
│ ├── FalhaEnergia.cs 
│ └── AlertaSeguranca.cs 
├── Services/ 
│ ├── FalhaService.cs 
│ ├── AlertaService.cs 
│ └── RelatorioService.cs 
├── README.md 
    
## 💡 Aplicabilidade 
  
Este projeto demonstra como falhas de energia podem comprometer a segurança de sistemas críticos, e como um software de monitoramento pode ajudar na prevenção e resposta rápida. Ele é aplicável em empresas de energia, hospitais, centros de dados e ambientes industriais. 