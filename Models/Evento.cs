using System;

namespace FalhasEnergiaCiber.Models
{
    // Classe base para todos os tipos de eventos
    public class Evento
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }

        public Evento(DateTime data, string descricao, string tipo)
        {
            Data = data;
            Descricao = descricao;
            Tipo = tipo;
        }

        // Exibe informações básicas do evento
        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"[{Tipo}] {Data}: {Descricao}");
        }
    }
}
