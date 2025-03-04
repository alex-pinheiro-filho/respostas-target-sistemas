using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Target_Sistemas.Exercicios
{
    class Exercicio4
    {
        public static void Executar()
        {
            Console.WriteLine("\nExercício 4: Calcular o percentual de representação do faturamento por Estado.");
            Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>()
            {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53}
            };

            double totalMensal = faturamentoEstados.Values.Sum();

            foreach (var estado in faturamentoEstados)
            {
                double percentual = (estado.Value / totalMensal) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }
    }
}
