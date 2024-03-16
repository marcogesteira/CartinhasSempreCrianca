using CartinhasSempreCrianca.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class ModeradorTests
    {
        [Fact]
        public void DeveCriarModeradorComSucesso()
        {
            //Arrange
            string senha = "Senha123";
            Moderador moderador = new Moderador("João", "teste@test.com", senha);

            //Assert
            Assert.NotNull(moderador.Nome);
            Assert.NotNull(moderador.Email);
            Assert.True(moderador.Senha != senha);
        }
        [Fact]
        public void NaoDeveCriarModeradorComEmailInvalido()
        {
            //Assert
            Assert.Throws<ArgumentException>(() => {
                Moderador moderador = new Moderador("João", "teste@test", "Senha123");
            });
        }
    }
}
