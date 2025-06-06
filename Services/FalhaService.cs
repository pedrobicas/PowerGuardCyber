using System;
using FalhasEnergiaCiber.Models;

namespace FalhasEnergiaCiber.Services
{
    public class FalhaService
    {
        // Cria uma instância de FalhaEnergia com validação da duração
        public FalhaEnergia CriarFalha(DateTime data, string descricao, int duracao)
        {
            if (duracao <= 0)
                throw new ArgumentException("Duração deve ser positiva.");

            return new FalhaEnergia(data, descricao, duracao);
        }
    }
}
