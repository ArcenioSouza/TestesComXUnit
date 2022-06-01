using System;
using Ex1Veiculo;
using Ex2Imposto;
using Ex3Personagem;
using Ex7Funcionarios;
using Jokenpo;

namespace Main
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Bem vindo ao App Colection Exercises");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Escolha uma das opções de exercicios para visualiza-lo:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 - Exercicio sobre Veiculo;\r\n2 - Exercicio sobre Imposto;\r\n3 - Exercicio sobre Personagem\r\n4 - Exercicio sobre Funcionarios\r\n5 - App Jokenpo");
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
                    ProgramFuncionarios.Main();
                    break;
                case "5":
                    ProgramJokenpo.Main();
                    break;
                default:
                    break;
            }
        }
    }
}

