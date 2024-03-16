using CartinhasSempreCrianca.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class PadrinhoTests
    {
        [Fact]
        public void DeveCriarPadrinhoComSucesso()
        {
            //Arrange
            string senha = "Senha123";
            Padrinho padrinho = new Padrinho("João", "teste@test.com", senha, "2199998-9888", true);

            //Assert
            Assert.NotNull(padrinho.Nome);
            Assert.NotNull(padrinho.Email);
            Assert.NotNull(padrinho.Telefone);
            Assert.True(padrinho.Senha != senha);
        }
        [Fact]
        public void NaoDeveCriarPadrinhoComEmailInvalido()
        {
            //Assert
            Assert.Throws<ArgumentException>(() => {
                Padrinho padrinho = new Padrinho("João", "teste@test", "Senha123", "2199998-9888", true);
            });
        }
    }
}
