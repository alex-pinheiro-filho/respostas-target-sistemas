using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Target_Sistemas.Exercicios
{
    public class Exercicio5
    {
        public static void Executar()
        {
            Console.WriteLine("\nExercício 5: Inverter string.");
            Console.Write("Digite uma string: ");
            string? texto = Console.ReadLine();
            string textoInvertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }

            Console.WriteLine("Texto original: " + texto);
            Console.WriteLine("Texto invertido: " + textoInvertido);
        }
    }
}
