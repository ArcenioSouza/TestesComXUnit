using System;
using Xunit;
using Jokenpo.Model;

namespace JokenpoTest
{
    public class JokenpoTest
    {
        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("4")]
        [InlineData("0")]
        public void Pessoa_RecebeOpcao_RetornaInteiroIgualOpcaoOuZero(string opcao)
        {
            //Arrange
            var partida = new Partida();
            //Act
            var result = partida.Pessoa(opcao);
            var expected = int.Parse(opcao) > 3 || int.Parse(opcao) == 0 ? 0 : int.Parse(opcao);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [Trait("Categoria", "Empate")]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(3, 3, 0)]

        [Trait("Categoria", "VitoriaPessoa")]
        [InlineData(1, 3, 1)]
        [InlineData(2, 1, 1)]
        [InlineData(3, 2, 1)]

        [Trait("Categoria", "VitoriaRobo")]
        [InlineData(1, 2, -1)]
        [InlineData(2, 3, -1)]
        [InlineData(3, 1, -1)]

        public void Resultado_RecebePessoaRoboEsperado_RetornaInteiroigualEsperado(int pessoa, int robo, int expected)
        {
            //Arrange
            var partida = new Partida();
            //Act
            var result = partida.Resultado(pessoa, robo);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
