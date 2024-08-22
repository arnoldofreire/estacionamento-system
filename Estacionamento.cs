// Estacionamento.cs
using System;
using System.Collections.Generic;

public class Estacionamento
{
    private List<Veiculo> veiculos = new List<Veiculo>();
    private const decimal PrecoPorHora = 5.00m;

    public void AdicionarVeiculo(string placa)
    {
        Veiculo veiculo = new Veiculo(placa);
        veiculos.Add(veiculo);
        Console.WriteLine($"Veículo de placa {placa} adicionado às {veiculo.HoraEntrada}");
    }

    public void RemoverVeiculo(string placa)
    {
        Veiculo veiculo = veiculos.Find(v => v.Placa.ToUpper() == placa.ToUpper());
        
        if (veiculo != null)
        {
            TimeSpan tempoEstacionado = DateTime.Now - veiculo.HoraEntrada;
            decimal valorCobrado = CalcularValorCobranca(tempoEstacionado);
            veiculos.Remove(veiculo);
            Console.WriteLine($"Veículo de placa {placa} removido. Tempo estacionado: {tempoEstacionado.TotalHours:F2} horas. Valor cobrado: R${valorCobrado:F2}");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado!");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo estacionado.");
        }
        else
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Hora de entrada: {veiculo.HoraEntrada}");
            }
        }
    }

    private decimal CalcularValorCobranca(TimeSpan tempoEstacionado)
    {
        return (decimal)tempoEstacionado.TotalHours * PrecoPorHora;
    }
}
