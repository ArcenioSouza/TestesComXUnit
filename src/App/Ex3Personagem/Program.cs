using System;
using Ex3Personagem.Model;

namespace Ex3Personagem
{
    public class ProgramPersonagem
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Bem vindo ao RPG Starter");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Escolha o seu personagem?\r\n1 - Guerreiro(a)\r\n2 - Mago(a)");
            string OpPersonagem = Console.ReadLine();

            if (OpPersonagem == "1")
            {
                Console.WriteLine("Digite o nome do personagem: ");
                string NomePersonagem = Console.ReadLine();
                Guerreiro Jogador = new Guerreiro(NomePersonagem, 200, 20, 0, 20, 100, 1);
                Console.WriteLine("Guerreiro " + NomePersonagem + " criado com sucesso!");
                Console.WriteLine("---------------------------");

                // Capitulo 1 da história --------------------
                Console.WriteLine("------ Capitulo 1 -------");
                Console.WriteLine("Você quer ser programador(a), está querendo evoluir e precisa escolher qual linguagem começar:");
                Console.WriteLine("1 - C#\r\n2 - Java\r\n3 - Javascript");
                string OpLinguagem = Console.ReadLine();
                switch (OpLinguagem)
                {
                    case "1":
                        Jogador.AprenderHabilidade("Programador C#");
                        Console.WriteLine($"Parabens!!! Vc aprendeu uma nova habilidade");
                        Jogador.ListarHabilidades();
                        Console.WriteLine("---------------------------");
                        break;
                    case "2":
                        Jogador.AprenderHabilidade("Programador Java");
                        Console.WriteLine($"Parabens!!! Vc aprendeu uma nova habilidade");
                        Jogador.ListarHabilidades();
                        Console.WriteLine("---------------------------");
                        break;
                    case "3":
                        Jogador.AprenderHabilidade("Programador Javascript");
                        Console.WriteLine($"Parabens!!! Vc aprendeu uma nova habilidade");
                        Jogador.ListarHabilidades();
                        Console.WriteLine("---------------------------");
                        break;
                    default:
                        break;
                }

                // Capitulo 2 da historia --------------
                Console.WriteLine("------ Capitulo 2 -------");
                Console.WriteLine("Você chegou ao primeiro desafio da sua trajetória, conseguiu uma entrevista na GFT, mas precisa superar a Graziele Resende...");
                Console.WriteLine("Faça um ataque acima de 300 de poder!!!");
                Console.WriteLine($"Digite:\r\n1 - Atacar\r\n2 - Desistir");
                string OpAtaque = Console.ReadLine();
                switch (OpAtaque)
                {
                    case "1":
                        double valorAtaque = Jogador.Attack();
                        bool isTrue = false;
                        while (isTrue == false)
                        {
                            if (valorAtaque > 300)
                            {
                                Jogador.LvlUp();
                                Jogador.ListarEvolucao();
                                isTrue = true;
                            }
                            else
                            {
                                Console.WriteLine($"Ataque fraco! Tente novamente ou desista");
                                Console.WriteLine($"Digite:\r\n1 - Atacar\r\n2 - Desistir");
                                OpAtaque = Console.ReadLine();
                                if (OpAtaque == "1")
                                {
                                    valorAtaque = Jogador.Attack();
                                }
                                else
                                {
                                    Console.WriteLine($"Sua jornada na GFT vai ter que esperar!");
                                    isTrue = true;
                                }
                            }
                        }
                        Console.WriteLine("---------------------------");
                        break;
                    case "2":
                        Console.WriteLine($"Sua jornada na GFT vai ter que esperar!");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Digite o nome do personagem: ");
                string NomePersonagem = Console.ReadLine();
                Mago Jogador = new Mago(NomePersonagem, 100, 200, 0, 200, 10, 1);
                Console.WriteLine("Mago(a) " + NomePersonagem + " criado com sucesso!");
                Console.WriteLine("---------------------------");

                Console.WriteLine("------ Capitulo 1 -------");
                Console.WriteLine("Você quer ser programador(a), está querendo evoluir e precisa escolher qual linguagem começar:");
                Console.WriteLine("1 - C#\r\n2 - Java\r\n3 - Javascript");
                string OpLinguagem = Console.ReadLine();
                switch (OpLinguagem)
                {
                    case "1":
                        Jogador.AprenderMagia("Programador C#");
                        Console.WriteLine($"Parabens!!! Vc aprendeu uma nova magia");
                        Jogador.ListarMagias();
                        Console.WriteLine("---------------------------");
                        break;
                    case "2":
                        Jogador.AprenderMagia("Programador Java");
                        Console.WriteLine($"Parabens!!! Vc aprendeu uma nova magia");
                        Jogador.ListarMagias();
                        Console.WriteLine("---------------------------");
                        break;
                    case "3":
                        Jogador.AprenderMagia("Programador Javascript");
                        Console.WriteLine($"Parabens!!! Vc aprendeu uma nova magia");
                        Jogador.ListarMagias();
                        Console.WriteLine("---------------------------");
                        break;
                    default:
                        break;
                }

                // Capitulo 2 da historia --------------
                Console.WriteLine("------ Capitulo 2 -------");
                Console.WriteLine("Você chegou ao primeiro desafio da sua trajetória, conseguiu uma entrevista na GFT, mas precisa superar a Graziele Resende...");
                Console.WriteLine("Faça um ataque acima de 300 de poder!!!");
                Console.WriteLine($"Digite:\r\n1 - Atacar\r\n2 - Desistir");
                string OpAtaque = Console.ReadLine();
                switch (OpAtaque)
                {
                    case "1":
                        double valorAtaque = Jogador.Attack();
                        bool isTrue = false;
                        while (isTrue == false)
                        {
                            if (valorAtaque > 300)
                            {
                                Jogador.LvlUp();
                                Jogador.ListarEvolucao();
                                isTrue = true;
                            }
                            else
                            {
                                Console.WriteLine($"Ataque fraco! Tente novamente ou desista");
                                Console.WriteLine($"Digite:\r\n1 - Atacar\r\n2 - Desistir");
                                OpAtaque = Console.ReadLine();
                                if (OpAtaque == "1")
                                {
                                    valorAtaque = Jogador.Attack();
                                }
                                else
                                {
                                    Console.WriteLine($"Sua jornada na GFT vai ter que esperar!");
                                    isTrue = true;
                                }
                            }
                        }
                        Console.WriteLine("---------------------------");
                        break;
                    case "2":
                        Console.WriteLine($"Sua jornada na GFT vai ter que esperar!");
                        break;
                }
            }
        }
    }
}
