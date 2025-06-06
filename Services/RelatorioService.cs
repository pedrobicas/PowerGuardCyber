using System;
using System.Collections.Generic;
using System.IO;
using FalhasEnergiaCiber.Models;

namespace FalhasEnergiaCiber.Services
{
    public class RelatorioService
    {
        // Exibe no console todos os eventos registrados
        public void GerarRelatorio(List<Evento> eventos)
        {
            Console.WriteLine("\n==== RELATÓRIO GERAL DE EVENTOS ====");

            foreach (var ev in eventos)
            {
                ev.ExibirDetalhes();
            }

            Console.WriteLine("=====================================\n");
        }

        // Exporta os eventos para um arquivo de texto
        public void ExportarParaArquivo(List<Evento> eventos, string caminho)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    writer.WriteLine("==== RELATÓRIO DE EVENTOS ====");

                    foreach (var ev in eventos)
                    {
                        writer.WriteLine($"[{ev.Tipo}] {ev.Data.ToShortDateString()}: {ev.Descricao}");

                        // Escreve detalhes específicos conforme o tipo do evento
                        if (ev is FalhaEnergia falha)
                        {
                            writer.WriteLine($"Duração: {falha.DuracaoMinutos} minutos");
                        }
                        else if (ev is AlertaSeguranca alerta)
                        {
                            writer.WriteLine($"Nível de Criticidade: {alerta.NivelCriticidade}");
                        }

                        writer.WriteLine();
                    }

                    writer.WriteLine("=================================");
                }

                Console.WriteLine($"Relatório exportado com sucesso para: {caminho}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar relatório: {ex.Message}\n");
            }
        }
    }
}
