using System;
using Xunit;
using Ex2Imposto.Model;

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
            var result = Livro.calculaImposto();
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
            var result = Livro.calculaImposto();
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
