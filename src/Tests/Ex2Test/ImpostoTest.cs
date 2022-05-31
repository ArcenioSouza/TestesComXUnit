using System;
using Xunit;
using Ex2Imposto.Model;
using System.Collections.Generic;

namespace Ex2Test
{
    public class ImpostoTest
    {
        [Fact]
        public void CalculaImposto_ChamaMetodoLivrosDiversos_RetornaValorImposto()
        {
            //Arrange
            var Livro = new Livro("Harry Potter", 100, 10, "J. K. Rowling", "fantasia", 300);
            double expected = 10;
            //Act
            var result = Livro.CalculaImposto();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculaImposto_ChamaMetodoLivrosEducativos_RetornaValorImposto()
        {
             //Arrange
            var Livro = new Livro("Harry Potter", 100, 10, "J. K. Rowling", "educativo", 300);
            double expected = 0;
            //Act
            var result = Livro.CalculaImposto();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculaImposto_ChamaMetodoVideoGameUsado_RetornaValorImposto()
        {
            //Arrange
            var VideoGame = new VideoGame("PS4", 1800, 100, "Sony", "Slim", true);
            //Act
            var result = VideoGame.CalculaImposto();
            var expected = 1800 * 0.25;
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculaImposto_ChamaMetodoVideoGameNovo_RetornaValorImposto()
        {
            //Arrange
            var VideoGame = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            var expected = 1800 * 0.45;
            //Act
            var result = VideoGame.CalculaImposto();            
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ListaLivros_VerificaSeEstaVazia_RetornaTrue()
        {
            //Arrange
            List<Livro> livros = new List<Livro>();
            List<VideoGame> games = new List<VideoGame>();
            var loja = new Loja("Americanas", "12345678", livros, games);
            //Act
            //Assert
            Assert.Empty(loja.Livros);
        }

        [Fact]
        public void ListaLivros_VerificaSePossueLivros_RetornaTrue()
        {
            //Arrange
            Livro livro1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            List<Livro> livros = new List<Livro>();
            livros.Add(livro1);
            List<VideoGame> games = new List<VideoGame>();
            var loja = new Loja("Americanas", "12345678", livros, games);
            //Act
            //Assert
            Assert.NotEmpty(loja.Livros);
        }

        [Fact]
        public void ListaVideoGames_VerificaSeEstaVazia_RetornaTrue()
        {
            //Arrange
            List<Livro> livros = new List<Livro>();
            List<VideoGame> games = new List<VideoGame>();
            var loja = new Loja("Americanas", "12345678", livros, games);
            //Act
            //Assert
            Assert.Empty(loja.VideoGames);
        }

        [Fact]
        public void ListaVideoGames_VerificaSePossueVideoGames_RetornaTrue()
        {
            //Arrange
            VideoGame videoGame1 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            List<Livro> livros = new List<Livro>();
            List<VideoGame> games = new List<VideoGame>();
            games.Add(videoGame1);
            var loja = new Loja("Americanas", "12345678", livros, games);
            //Act
            //Assert
            Assert.NotEmpty(loja.VideoGames);
        }

        [Fact]
        public void CalculaPatrimonio_SomaValoresDeLivrosEVideoGames_RetornaValorTotalDoPatrimonio()
        {
            //Arrange
            VideoGame videoGame1 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            Livro livro1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            List<Livro> livros = new List<Livro>();
            List<VideoGame> games = new List<VideoGame>();
            games.Add(videoGame1);
            livros.Add(livro1);
            var loja = new Loja("Americanas", "12345678", livros, games);
            var expected = 1800 + 40;
            //Act
            var result = loja.CalculaPatrimonio();
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
