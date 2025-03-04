using ProjetoModular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Questoes_Target_Sistemas.Exercicios
{
    public class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("\nExercício 3: Análisar o faturamento diário e contar quantos dias tiveram o faturamento superior a média.");

            string fileName = "dados.json";
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Arquivo 'dados.json' não encontrado na raiz do programa.");
                return;
            }

            string jsonData = File.ReadAllText(fileName);
            List<FaturamentoDia> dados = JsonSerializer.Deserialize<List<FaturamentoDia>>(jsonData);

            if (dados == null || dados.Count == 0)
            {
                Console.WriteLine("Nenhum dado de faturamento foi encontrado.");
                return;
            }

            var diasComFaturamento = dados.Where(d => d.valor > 0).ToList();

            if (diasComFaturamento.Count == 0)
            {
                Console.WriteLine("Não há dados de faturamento disponíveis (valores > 0).");
                return;
            }

            double menorValor = diasComFaturamento.Min(d => d.valor);
            double maiorValor = diasComFaturamento.Max(d => d.valor);
            double mediaMensal = diasComFaturamento.Average(d => d.valor);
            int diasAcimaMedia = diasComFaturamento.Count(d => d.valor > mediaMensal);

            Console.WriteLine("Menor faturamento do mês: " + menorValor);
            Console.WriteLine("Maior faturamento do mês: " + maiorValor);
            Console.WriteLine("Número de dias com faturamento acima da média: " + diasAcimaMedia);
        }
    }
    class FaturamentoDia
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
}
