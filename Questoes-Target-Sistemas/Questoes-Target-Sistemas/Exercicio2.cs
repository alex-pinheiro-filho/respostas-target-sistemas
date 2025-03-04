using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Target_Sistemas.Exercicios
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("\nExercício 2: Verificar se o número a sua escolha pertence a Sequência de Fibonacci.");
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            int numero;
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            bool pertence = false;
            int a = 0, b = 1;

            // Se o número for 0 ou 1, já está na sequência
            if (numero == a || numero == b)
                pertence = true;
            else
            {
                int fib = a + b;
                // Gera os próximos números da sequência até ultrapassar ou encontrar o número
                while (fib <= numero)
                {
                    if (fib == numero)
                    {
                        pertence = true;
                        break;
                    }
                    a = b;
                    b = fib;
                    fib = a + b;
                }
            }

            Console.WriteLine(pertence ? $"{numero} pertence à sequência de Fibonacci." : $"{numero} não pertence à sequência de Fibonacci.");
        }
    }
}

