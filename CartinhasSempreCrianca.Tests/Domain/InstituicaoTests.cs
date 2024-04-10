using CartinhasSempreCrianca.Domain.Cartinha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class InstituicaoTests
    {
        [Fact]
        public void DeveCriarInstituicaoComSucesso()
        {
            //Arrange
            Cartinha cartinha = new Cartinha("Carrinho", 1050, DateTime.Now, "www.test.com");
            Crianca crianca = new Crianca("João", 6);
            Instituicao instituicao = new Instituicao("Creche Feliz", new Diretor());

            //Act
            crianca.AdicionarCartinha(cartinha);
            instituicao.AdicionarCrianca(crianca);

            //Assert
            Assert.NotNull(crianca.Nome);
            Assert.NotNull(instituicao.Nome);

            Assert.True(crianca.Cartinhas.Count > 0);
            Assert.Same(crianca.Cartinhas[0], cartinha);

            Assert.True(instituicao.Criancas.Count > 0);
            Assert.Same(instituicao.Criancas[0], crianca);
        }
    }
}
