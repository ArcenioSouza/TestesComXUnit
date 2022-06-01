using System;
using Xunit;
using Ex3Personagem.Model;

namespace Ex3Test
{
    public class PersonagemTest
    {
        [Fact]
        public void LvlUp_ChamaMetodo_RetornaLevelAlterado()
        {
            //Arrange
            Guerreiro Jogador = new Guerreiro("Jogador1", 200, 20, 0, 20, 100, 1);
            var expected = Jogador.Level + 1;
            //Act
            Jogador.LvlUp();
            //Assert
            Assert.Equal(expected, Jogador.Level);
        }

        [Fact]
        public void Attack_ChamaMetodo_RetornaResultadoMaiorQueZero()
        {
            //Arrange
            Guerreiro Jogador = new Guerreiro("Jogador1", 200, 20, 0, 20, 100, 1);
            //Act
            var result = Jogador.Attack();
            //Assert
            Assert.True(result > 0);
        }

        [Theory]
        [InlineData("Espada Giratória")]      
        public void AprenderHabilidade_RecebeString_RetornaItemNaListaDeHabilidades(string NomeHabilidade)
        {
            //Arrange
            Guerreiro Jogador = new Guerreiro("Jogador1", 200, 20, 0, 20, 100, 1);
            //Act
            Jogador.AprenderHabilidade(NomeHabilidade);
            //Assert
            Assert.True(Jogador.Habilidade.Count > 0);
        }

    }
}
