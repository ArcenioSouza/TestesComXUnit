using System.Threading;
using System;
using CaixaEletronico.Model;

namespace CaixaEletronico
{
    public class ProgramCaixaEletronico
    {
        public static void Main()
        {
            bool SaqueLiberado = false;
            int ValorSaque = 0;

            while (SaqueLiberado == false)
            {
                Console.WriteLine($"-----------------------------------");
                Console.WriteLine($"Bem vindo ao App Caixa Eletrônico");
                Console.WriteLine($"Digite um valor para sacar:");

                string saque = Console.ReadLine();
                ValorSaque = saque == "" ? 0 : Int32.Parse(saque);

                if (ValorSaque % 2 == 1)
                {
                    Console.WriteLine($"----------------------------------------------------------");
                    Console.WriteLine($"Só temos notas de 100, 50, 20 e 10 disponíveis\nImpossível realizar o saque nesse valor");
                    Console.WriteLine($"----------------------------------------------------------");
                    Console.WriteLine($"Tente novamente");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine($"------------------------------------------------------");
                    Console.WriteLine($"Fazendo a contagem das notas... Por favor aguarde...");
                    Console.WriteLine($"------------------------------------------------------");
                    Thread.Sleep(2000);
                    SaqueLiberado = true;
                }
            }

            Caixa caixa = new Caixa();
            caixa.Saque(ValorSaque);
        }
    }
}

/* Caixa Eletrônico
Você está resolvendo este problema.
Este problema foi utilizado em 1457 Dojo(s).

Desenvolva um programa que simule a entrega de notas quando um cliente efetuar um saque em um caixa eletrônico. Os requisitos básicos são os seguintes:

Entregar o menor número de notas;
É possível sacar o valor solicitado com as notas disponíveis;
Saldo do cliente infinito;
Quantidade de notas infinito (pode-se colocar um valor finito de cédulas para aumentar a dificuldade do problema);
Notas disponíveis de R$ 100,00; R$ 50,00; R$ 20,00 e R$ 10,00
Exemplos:

Valor do Saque: R$ 30,00 – Resultado Esperado: Entregar 1 nota de R$20,00 e 1 nota de R$ 10,00.
Valor do Saque: R$ 80,00 – Resultado Esperado: Entregar 1 nota de R$50,00 1 nota de R$ 20,00 e 1 nota de R$ 10,00. */
