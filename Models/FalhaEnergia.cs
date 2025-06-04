using System;

namespace FalhasEnergiaCiber.Models
{
    public class FalhaEnergia : Evento
    {
        public int DuracaoMinutos { get; set; }

        public FalhaEnergia(DateTime data, string descricao, int duracao)
            : base(data, descricao, "Falha de Energia")
        {
            DuracaoMinutos = duracao;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Duração: {DuracaoMinutos} minutos\n");
        }
    }
}