using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Questao03.Models;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var faturamento = CarregarFaturamento("faturamento.json");

            if (faturamento == null || !faturamento.Any())
            {
                Console.WriteLine("Nenhum dado de faturamento foi encontrado.");
                return;
            }

            var menorFaturamento = faturamento.Min(f => f.Valor);
            var maiorFaturamento = faturamento.Max(f => f.Valor);

            var mediaMensal = faturamento.Where(f => f.Valor > 0).Average(f => f.Valor);

            var diasAcimaDaMedia = faturamento.Count(f => f.Valor > mediaMensal);

            Console.WriteLine($"Menor Faturamento: R$ {menorFaturamento}");
            Console.WriteLine($"Maior Faturamento: R$ {maiorFaturamento}");
            Console.WriteLine($"Dias com faturamento superior à média mensal: {diasAcimaDaMedia}");
        }

        static List<FaturamentoDia> CarregarFaturamento(string caminhoArquivo)
        {
            try
            {
                var json = File.ReadAllText(caminhoArquivo);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var dados = JsonSerializer.Deserialize<Dictionary<string, List<FaturamentoDia>>>(json, options);
                return dados["faturamento"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar o arquivo JSON: " + ex.Message);
                return new List<FaturamentoDia>();
            }
        }
    }
}
