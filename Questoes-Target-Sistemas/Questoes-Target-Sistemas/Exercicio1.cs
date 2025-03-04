using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Target_Sistemas.Exercicios
{
    public class Exercicio1
    {
        public static void Executar()
        {
            Console.WriteLine("\nExercício 1: Retornar o valor da variável SOMA.");
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"O valor final da variável SOMA é: {SOMA}");
        }
    }
}
