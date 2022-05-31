using System;
using Ex1Veiculo;
using Ex2Imposto;
using Ex3Personagem;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao App Colection Exercises");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Escolha uma das opções de exercicios para visualiza-lo:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 - Exercicio sobre Veiculo;\r\n2 - Exercicio sobre Imposto;\r\n3 - Exercicio sobre Personagem");
            var opcao = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            switch (opcao)
            {
                case "1":
                    ProgramVeiculo.Main();
                    break;
                case "2":
                    ProgramImposto.Main();
                    break;
                case "3":
                    ProgramPersonagem.Main();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                default:
                    break;
            }
        }
    }
}

