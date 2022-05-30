using System;
using Xunit;

namespace Ex1Test
{
    public class VeiculoTest
    {
        [Fact]
        public void Acelerar_RetornaVelocidadeMaiorQueZero()
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
    }
}
