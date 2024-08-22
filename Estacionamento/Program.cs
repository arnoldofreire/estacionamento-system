// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite a placa do veículo:");
                    string placaAdicionar = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placaAdicionar);
                    break;
                case "2":
                    Console.WriteLine("Digite a placa do veículo:");
                    string placaRemover = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placaRemover);
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
