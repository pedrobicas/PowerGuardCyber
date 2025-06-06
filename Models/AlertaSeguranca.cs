using System;

namespace FalhasEnergiaCiber.Models
{
    // Representa um evento de alerta de segurança
    public class AlertaSeguranca : Evento
    {
        public string NivelCriticidade { get; set; }

        public AlertaSeguranca(DateTime data, string descricao, string nivel)
            : base(data, descricao, "Alerta de Segurança")
        {
            NivelCriticidade = nivel;
        }

        // Exibe detalhes do alerta, incluindo o nível de criticidade
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Nível de Criticidade: {NivelCriticidade}\n");
        }
    }
}
