using CartinhasSempreCrianca.Domain.Cartinha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class CriancaTests
    {
        [Fact]
        public void DeveCriarCriancaComSucesso()
        {
            //Arrange
            Cartinha cartinha = new Cartinha(1050, DateTime.Now, "www.test.com");
            Crianca crianca = new Crianca("João", 6, "Carrinho");

            //Act
            crianca.AdicionarCartinha(cartinha);

            //Assert
            Assert.NotNull(crianca.Nome);

            Assert.True(crianca.Cartinhas.Count > 0);
            Assert.Same(crianca.Cartinhas[0], cartinha);
        }
    }
}
