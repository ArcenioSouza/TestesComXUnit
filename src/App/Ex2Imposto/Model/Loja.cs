using System;
using System.Collections.Generic;

namespace Ex2Imposto.Model
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<VideoGame> VideoGames { get; set; }
        public List<Livro> Livros { get; set; }
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            VideoGames = videoGames;
            Livros = livros;
        }

        public void ListaLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros");
            }
            else
            {
                foreach (var item in Livros)
                {
                    Console.WriteLine(item.Nome);
                }
            }

        }

        public void ListaVideoGames()
        {
            if (VideoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem video games");
            }
            else
            {
                foreach (var item in VideoGames)
                {
                    Console.WriteLine(item.Nome);
                }
            }

        }

        public double CalculaPatrimonio()
        {
            double valorPatrimonio = 0;

            foreach (var item in VideoGames)
            {
                valorPatrimonio += item.Preco;
            }

            foreach (var item in Livros)
            {
                valorPatrimonio += item.Preco;
            }

            return valorPatrimonio;
        }
    }

}