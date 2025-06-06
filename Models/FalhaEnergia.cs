using System;

namespace FalhasEnergiaCiber.Models
{
    // Representa um evento de falha de energia
    public class FalhaEnergia : Evento
    {
        public int DuracaoMinutos { get; set; }

        public FalhaEnergia(DateTime data, string descricao, int duracao)
            : base(data, descricao, "Falha de Energia")
        {
            DuracaoMinutos = duracao;
        }

        // Exibe detalhes da falha, incluindo duração
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Duração: {DuracaoMinutos} minutos\n");
        }
    }
}
