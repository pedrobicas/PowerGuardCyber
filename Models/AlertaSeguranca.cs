using System;

namespace FalhasEnergiaCiber.Models
{
    public class AlertaSeguranca : Evento
    {
        public string NivelCriticidade { get; set; }

        public AlertaSeguranca(DateTime data, string descricao, string nivel)
            : base(data, descricao, "Alerta de Segurança")
        {
            NivelCriticidade = nivel;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Nível de Criticidade: {NivelCriticidade}\n");
        }
    }
}
