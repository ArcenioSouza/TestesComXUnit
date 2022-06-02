using System;
using Jokenpo.Model;

namespace Jokenpo
{
    public class ProgramJokenpo
    {
        public static void Main()
        {
            Random random = new Random();
            int robo = random.Next(3) + 1;
            
            Partida partida = new Partida();
            partida.Menu();
            string pessoa = Console.ReadLine();
            if(partida.Pessoa(pessoa) != 0)
            {
                partida.Robo(robo);
            }
            else
            {
                Console.WriteLine($"---------------------------");
            }

            try
            {
                int opcao = int.Parse(pessoa);
                partida.Resultado(opcao, robo);
            }
            catch(Exception)
            {
                return;
            }
        }
    }
}
