namespace Questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var faturamentoPorEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            var faturamentoTotal = 0.0;
            foreach (var faturamento in faturamentoPorEstado.Values)
            {
                faturamentoTotal += faturamento;
            }

            Console.WriteLine("Percentual de representação por estado:");

            foreach (var estado in faturamentoPorEstado)
            {
                var percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }
    }
}
