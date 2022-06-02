using System;
using Xunit;
using CaixaEletronico.Model;

namespace CaixaEletronicoTest
{
    public class CaixaEletronicoTest
    {
        [Theory]
        [InlineData(200, 2, 0, 0, 0)]
        [InlineData(220, 2, 0, 1, 0)]
        [InlineData(270, 2, 1, 1, 0)]
        [InlineData(380, 3, 1, 1, 1)]
        public void Saque_RecebeValorEQtdNotas_RetornaQtdNotasIguais(int valor, int notas100, int notas50, int notas20, int notas10)
        {
            //Arrange
            Caixa caixa = new Caixa();
            //Act
            caixa.Saque(valor);
            //Assert
            Assert.Equal(notas100, caixa.Notas100);
            Assert.Equal(notas50, caixa.Notas50);
            Assert.Equal(notas20, caixa.Notas20);
            Assert.Equal(notas10, caixa.Notas10);
        }
    }
}
