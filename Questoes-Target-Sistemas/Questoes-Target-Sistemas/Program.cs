using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Questoes_Target_Sistemas.Exercicios;

namespace ProjetoModular
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {

                ExibirMenu();

                string? opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Exercicio1.Executar();
                        AguardarRetorno();
                        break;
                    case "2":
                        Exercicio2.Executar();
                        AguardarRetorno();
                        break;
                    case "3":
                        Exercicio3.Executar();
                        AguardarRetorno();
                        break;
                    case "4":
                        Exercicio4.Executar();
                        AguardarRetorno();
                        break;
                    case "5":
                        Exercicio5.Executar();
                        AguardarRetorno();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Escolha uma opção válida.");
                        break;
                }
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\nLista com opções de exercícios:\n");
            Console.WriteLine("1 - Exercício 1 - Retornar o valor da variável SOMA.");
            Console.WriteLine("2 - Exercício 2 - Verificar se o número a sua escolha pertence a Sequência de Fibonacci.");
            Console.WriteLine("3 - Exercício 3 - Análisar o faturamento diário e contar quantos dias tiveram o faturamento superior a média.");
            Console.WriteLine("4 - Exercício 4 - Calcular o percentual de representação do faturamento por Estado.");
            Console.WriteLine("5 - Exercício 5 - Inverter string.");
            Console.WriteLine("0 - Sair.");
            Console.Write("\nDigite o número do exercício: ");
        }

        static void AguardarRetorno()
        {
            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu inicial.. ");
            Console.ReadKey();
            Console.Clear();
        }
    }

}