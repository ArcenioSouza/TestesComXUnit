using System;
using Xunit;
using Ex7Funcionarios.Model;

namespace Ex7Test
{
    public class FuncionarioTest
    {
        [Fact]
        public void BonificacaoGerente_ChamaMetodo_RetornaValorBonificacao()
        {
            //Arrange
            Gerente funcionario = new Gerente("Paulo", 27, 4000);
            var expected = funcionario.Salario + 10000;
            //Act
            var result = funcionario.Bonificacao();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BonificacaoSupervisor_ChamaMetodo_RetornaValorBonificacao()
        {
            //Arrange
            Supervisor funcionario = new Supervisor("Paulo", 27, 4000);
            var expected = funcionario.Salario + 5000;
            //Act
            var result = funcionario.Bonificacao();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BonificacaoVendedor_ChamaMetodo_RetornaValorBonificacao()
        {
            //Arrange
            Vendedor funcionario = new Vendedor("Paulo", 27, 4000);
            var expected = funcionario.Salario + 3000;
            //Act
            var result = funcionario.Bonificacao();
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
