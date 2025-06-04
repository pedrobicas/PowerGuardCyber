using System;

namespace FalhasEnergiaCiber.Models
{
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

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"[{Tipo}] {Data:dd/MM/yyyy}: {Descricao}");
        }
    }
}