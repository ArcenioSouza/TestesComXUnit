using System;
using Ex1Veiculo;
using Ex2Imposto;
using Ex3Personagem;
using Ex7Funcionarios;
using Jokenpo;
using CaixaEletronico;

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
            Console.WriteLine("1 - Exercicio sobre Veiculo;\n2 - Exercicio sobre Imposto;\n3 - Exercicio sobre Personagem\n4 - Exercicio sobre Funcionarios\n5 - App Jokenpo\n6 - App Caixa Eletrônico");
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
                case "6":
                    ProgramCaixaEletronico.Main();
                    break;
                default:
                    break;
            }
        }
    }
}

