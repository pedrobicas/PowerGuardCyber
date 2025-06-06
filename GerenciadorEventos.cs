using System;
using System.Collections.Generic;
using FalhasEnergiaCiber.Models;
using FalhasEnergiaCiber.Services;

namespace FalhasEnergiaCiber
{
    public class GerenciadorEventos
    {
        private List<Evento> eventos = new List<Evento>();
        private RelatorioService relatorioService = new RelatorioService();

        // Registra uma nova falha de energia
        public void RegistrarFalha()
        {
            try
            {
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();

                Console.Write("Duração (minutos): ");
                int duracao = int.Parse(Console.ReadLine());

                if (duracao <= 0) throw new Exception("Duração deve ser positiva.");

                eventos.Add(new FalhaEnergia(data, descricao, duracao));
                Console.WriteLine("Falha registrada com sucesso!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}\n");
            }
        }

        // Registra um novo alerta de segurança
        public void RegistrarAlerta()
        {
            try
            {
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();

                Console.Write("Nível (Baixo/Médio/Alto): ");
                string nivel = Console.ReadLine();

                eventos.Add(new AlertaSeguranca(data, descricao, nivel));
                Console.WriteLine("Alerta registrado com sucesso!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar alerta: {ex.Message}\n");
            }
        }

        // Exibe todos os eventos registrados
        public void ListarEventos()
        {
            Console.WriteLine("\n==== EVENTOS REGISTRADOS ====");
            foreach (var ev in eventos)
            {
                ev.ExibirDetalhes();
            }
            Console.WriteLine("=============================\n");
        }

        // Simula um ataque caso haja falhas de energia registradas
        public void SimularAtaque()
        {
            Console.WriteLine("Simulando ataque cibernético durante apagão...");
            if (eventos.Exists(e => e.Tipo == "Falha de Energia"))
            {
                eventos.Add(new AlertaSeguranca(DateTime.Now, "Ataque simulado após falha elétrica", "Alto"));
                Console.WriteLine("Ataque simulado registrado.\n");
            }
            else
            {
                Console.WriteLine("Não há falhas registradas. Simulação não permitida.\n");
            }
        }

        // Gera um relatório e oferece opção de exportação
        public void GerarRelatorio()
        {
            relatorioService.GerarRelatorio(eventos);

            Console.Write("Deseja exportar para arquivo? (s/n): ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {
                Console.Write("Informe o caminho do arquivo (ex: relatorio.txt): ");
                string caminho = Console.ReadLine();
                relatorioService.ExportarParaArquivo(eventos, caminho);
            }
        }
    }
}
