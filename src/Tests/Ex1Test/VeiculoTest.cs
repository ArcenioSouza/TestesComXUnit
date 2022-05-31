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
            Veiculo veiculo = new Veiculo("Chevrolet", "Prisma", "EJE1839", "Vermelho", 150000, 18000);
            var testVeiculo = veiculo;
            testVeiculo.Ligar();
            var expected = 20;
            //Act
            testVeiculo.Acelerar();
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
            Veiculo testVeiculo = new Veiculo("Chevrolet", "Prisma", "EJE1839", "Vermelho", 150000, 18000);
            var expected = QtdCombustivel;
            //Act
            testVeiculo.Abastecer(QtdCombustivel);
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
            Veiculo testVeiculo = new Veiculo("Chevrolet", "Prisma", "EJE1839", "Vermelho", 150000, 18000);
            var expected = 0;
            //Act
            testVeiculo.Abastecer(QtdCombustivel);
            //Assert
            Assert.Equal(expected, testVeiculo.litrosCombustivel);
        }

        [Fact]
        public void Frear_ChamaMetodo_RetornaVelocidadeMenor()
        {
            //Arrange
            Veiculo testVeiculo = new Veiculo("Chevrolet", "Prisma", "AAA1010", "Vermelho", 150000, 17000);
            testVeiculo.Ligar();
            testVeiculo.Acelerar();
            testVeiculo.Acelerar();
            var expected = 20;
            //Act            
            testVeiculo.Frear();            
            //Assert
            Assert.Equal(expected, testVeiculo.Velocidade);
        }

        [Theory]
        [InlineData("Azul")]
        [InlineData("Verde")]

        public void Pintar_RecebeStringCor_RetornaNovaCorDoVeiculo(string NovaCor)
        {
            //Arrange
            Veiculo testVeiculo = new Veiculo("Chevrolet", "Prisma", "AAA1010", "Vermelho", 150000, 17000);
            var expected = NovaCor;
            //Act
            testVeiculo.Pintar(NovaCor);            
            //Assert
            Assert.Equal(expected, testVeiculo.Cor);
        }

        [Fact]
        public void Ligar_ChamaMetodo_RetornaTrue()
        {
            //Arrange
            Veiculo testVeiculo = new Veiculo("Chevrolet", "Prisma", "AAA1010", "Vermelho", 150000, 17000);
            var expected = true;
            //Act            
            testVeiculo.Ligar();           
            //Assert
            Assert.Equal(expected, testVeiculo.isLigado);
        }

         [Fact]
        public void Desligar_ChamaMetodo_RetornaFalse()
        {
            //Arrange
            Veiculo testVeiculo = new Veiculo("Chevrolet", "Prisma", "AAA1010", "Vermelho", 150000, 17000);
            var expected = false;
            testVeiculo.Ligar();
            //Act            
            testVeiculo.Desligar();           
            //Assert
            Assert.Equal(expected, testVeiculo.isLigado);
        }
    }
}
