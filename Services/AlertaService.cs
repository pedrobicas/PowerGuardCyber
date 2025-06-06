using System;
using FalhasEnergiaCiber.Models;

namespace FalhasEnergiaCiber.Services
{
    public class AlertaService
    {
        // Cria uma instância de AlertaSeguranca com validação do nível
        public AlertaSeguranca CriarAlerta(DateTime data, string descricao, string nivel)
        {
            if (string.IsNullOrEmpty(nivel))
                throw new ArgumentException("Nível de criticidade não pode ser vazio.");

            return new AlertaSeguranca(data, descricao, nivel);
        }
    }
}
