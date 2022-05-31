using System;
using System.Collections.Generic;
using Ex2Imposto.Model;

namespace Ex2Imposto
{
    public class ProgramImposto
    {
        public static void Main()
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor do Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 100, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            Console.WriteLine("R$ " + l2.CalculaImposto() + " de imposto sobre o livro " + l2.Nome);

            Console.WriteLine("R$ " + l3.CalculaImposto() + " de imposto sobre o livro " + l3.Nome);

            Console.WriteLine("Imposto sobre o video game " + ps4Usado.Nome + ", usado: " + ps4Usado.IsUsado + ", R$" + ps4Usado.CalculaImposto());
            Console.WriteLine("Imposto sobre o video game " + ps4.Nome + ", usado: " + ps4.IsUsado + ", R$" + ps4.CalculaImposto());

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("A loja Americanas possui estes livros para venda:");
            americanas.ListaLivros();

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("A loja Americanas possui estes video games para venda:");
            americanas.ListaVideoGames();

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("O patrimônio da loja é de R$" + americanas.CalculaPatrimonio());

        }
    }

}
