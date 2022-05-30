using System;
using Xunit;
using Ex1Veiculo;

namespace Ex1Test
{
    public class VeiculoTest
    {
        [Fact]
        public void Acelerar_ChamaMetodo_RetornaVelocidadeMaiorQueZero()
        {
            //Arrange
            var testVeiculo = new Veiculo("Chevrolet", "Prisma", "EJE1839", "Vermelho", 150000, 18000);
            testVeiculo.ligar();
            var expected = 20;
            //Act
            testVeiculo.acelerar();
            //Assert
            Assert.Equal(expected, testVeiculo.Velocidade);
        }

        [Theory]
        [InlineData(20)]
        [InlineData(40)]
        [InlineData(60)]

        public void Abastecer_RecebeNumeroInteiro_RetornaQuantidadeDeCombutivel(int QtdCombustivel)
        {
            //Arrange
            var testVeiculo = new Veiculo("Chevrolet", "Prisma", "EJE1839", "Vermelho", 150000, 18000);
            var expected = QtdCombustivel;
            //Act
            testVeiculo.abastecer(QtdCombustivel);
            //Assert
            Assert.Equal(expected, testVeiculo.litrosCombustivel);
        }

        [Theory]
        [InlineData(70)]
        [InlineData(62)]
        [InlineData(85)]

        public void Abastecer_RecebeNumeroInteiroMaiorQue60_RetornaQuantidadeDeCombutivelIgualZero(int QtdCombustivel)
        {
            //Arrange
            var testVeiculo = new Veiculo("Chevrolet", "Prisma", "EJE1839", "Vermelho", 150000, 18000);
            var expected = 0;
            //Act
            testVeiculo.abastecer(QtdCombustivel);
            //Assert
            Assert.Equal(expected, testVeiculo.litrosCombustivel);
        }

        [Fact]
        public void Frear_ChamaMetodo_RetornaVelocidadeMenor()
        {
            //Arrange
            var testVeiculo = new Veiculo("Chevrolet", "Prisma", "AAA1010", "Vermelho", 150000, 17000);
            testVeiculo.ligar();
            testVeiculo.acelerar();
            testVeiculo.acelerar();
            var expected = 20;
            //Act            
            testVeiculo.frear();            
            //Assert
            Assert.Equal(expected, testVeiculo.Velocidade);
        }

        [Theory]
        [InlineData("Azul")]
        [InlineData("Verde")]

        public void Pintar_RecebeStringCor_RetornaNovaCorDoVeiculo(string NovaCor)
        {
            //Arrange
            var testVeiculo = new Veiculo("Chevrolet", "Prisma", "AAA1010", "Vermelho", 150000, 17000);
            var expected = NovaCor;
            //Act
            testVeiculo.pintar(NovaCor);            
            //Assert
            Assert.Equal(expected, testVeiculo.Cor);
        }

    }
}
