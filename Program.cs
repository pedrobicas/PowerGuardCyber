using System;

namespace FalhasEnergiaCiber
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorEventos sistema = new GerenciadorEventos();
            string opcao;

            Console.WriteLine("SISTEMA DE MONITORAMENTO - LOGIN");
            Console.Write("Usuário: "); Console.ReadLine();
            Console.Write("Senha: "); Console.ReadLine();

            do
            {
                Console.WriteLine("\n==== MENU ====");
                Console.WriteLine("1. Registrar Falha de Energia");
                Console.WriteLine("2. Registrar Alerta de Segurança");
                Console.WriteLine("3. Listar Eventos");
                Console.WriteLine("4. Simular Ataque");
                Console.WriteLine("5. Gerar Relatório de Eventos");
                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": sistema.RegistrarFalha(); break;
                    case "2": sistema.RegistrarAlerta(); break;
                    case "3": sistema.ListarEventos(); break;
                    case "4": sistema.SimularAtaque(); break;
                    case "5": sistema.GerarRelatorio(); break;
                    case "0": Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida!\n"); break;
                }

            } while (opcao != "0");
        }
    }
}
