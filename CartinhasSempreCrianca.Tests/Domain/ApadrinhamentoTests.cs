using CartinhasSempreCrianca.Domain.Apadrinhamento;
using CartinhasSempreCrianca.Domain.Cartinha;
using CartinhasSempreCrianca.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class ApadrinhamentoTests
    {
        [Fact]
        //metodo + cenário + comportamento
        public void Contrutor_TestandoIncializacaoQuandoTiverValor_DeveCriarApadrinhamentoComSucesso()
        {
            //Arrange
            Padrinho padrinho = new Padrinho("João", "teste@test.com", "Senha123", "2199998-9888", true);
            Cartinha cartinha = new Cartinha(1050, DateTime.Now, "www.test.com");
            LocalDeRecolhimento localDeRecolhimento = new LocalDeRecolhimento("Rua das Couves, 35", "Centro", "Joaquim", "2199988-9888", "Das 14h às 18h");

            //Act
            var apadrinhamento = new Apadrinhamento(DateTime.Parse("05/07/2024"), DateTime.Parse("10/12/2024"), padrinho);
            apadrinhamento.AdicionarCartinha(cartinha);
            apadrinhamento.AdicionarLocal(localDeRecolhimento);

            //Assert
            Assert.NotNull(apadrinhamento);
            Assert.NotNull(cartinha.Desenho);
            Assert.NotNull(localDeRecolhimento.Endereco);

            Assert.True(apadrinhamento.Cartinhas.Count > 0);
            Assert.Same(apadrinhamento.Cartinhas[0], cartinha);

            Assert.True(apadrinhamento.LocaisDeRecolhimento.Count > 0);
            Assert.Same(apadrinhamento.LocaisDeRecolhimento[0], localDeRecolhimento);

        }
        [Fact]
        public void DeveCriarApadrinhamentoComDuasCartinhas()
        {
            //Arrange
            Padrinho padrinho = new Padrinho("João", "teste@test.com", "Senha123", "2199998-9888", true);
            Cartinha cartinha = new Cartinha(1050, DateTime.Now, "www.test.com");
            Cartinha cartinha2 = new Cartinha(3090, DateTime.Now, "www.test2.com");
            LocalDeRecolhimento localDeRecolhimento = new LocalDeRecolhimento("Rua das Couves, 35", "Centro", "Joaquim", "2199988-9888", "Das 14h às 18h");

            //Act
            Apadrinhamento apadrinhamento = new Apadrinhamento(DateTime.Parse("05/07/2024"), DateTime.Parse("10/12/2024"), padrinho);
            apadrinhamento.AdicionarCartinha(cartinha);
            apadrinhamento.AdicionarCartinha(cartinha2);
            apadrinhamento.AdicionarLocal(localDeRecolhimento);

            //Assert
            Assert.NotNull(apadrinhamento);
            Assert.NotNull(cartinha.Desenho);
            Assert.NotNull(localDeRecolhimento.Endereco);

            Assert.True(apadrinhamento.Cartinhas.Count > 1);
            Assert.Same(apadrinhamento.Cartinhas[0], cartinha);
            Assert.Same(apadrinhamento.Cartinhas[1], cartinha2);

            Assert.True(apadrinhamento.LocaisDeRecolhimento.Count > 0);
            Assert.Same(apadrinhamento.LocaisDeRecolhimento[0], localDeRecolhimento);
        }
        [Fact]
        public void DeveCriarApadrinhamentoComDoisLocais()
        {
            //Arrange
            Padrinho padrinho = new Padrinho("João", "teste@test.com", "Senha123", "2199998-9888", true);
            Cartinha cartinha = new Cartinha(1050, DateTime.Now, "www.test.com");
            LocalDeRecolhimento localDeRecolhimento = new LocalDeRecolhimento("Rua das Couves, 35", "Centro", "Joaquim", "2199988-9888", "Das 14h às 18h");
            LocalDeRecolhimento localDeRecolhimento2 = new LocalDeRecolhimento("Rua das Marrecas, 43", "Sul", "Joãozinho", "2198889-8999", "Das 08h às 18h");

            //Act
            Apadrinhamento apadrinhamento = new Apadrinhamento(DateTime.Parse("05/07/2024"), DateTime.Parse("10/12/2024"), padrinho);
            apadrinhamento.AdicionarCartinha(cartinha);
            apadrinhamento.AdicionarLocal(localDeRecolhimento);
            apadrinhamento.AdicionarLocal(localDeRecolhimento2);

            //Assert
            Assert.NotNull(apadrinhamento);
            Assert.NotNull(cartinha.Desenho);
            Assert.NotNull(localDeRecolhimento.Endereco);

            Assert.True(apadrinhamento.Cartinhas.Count > 0);
            Assert.Same(apadrinhamento.Cartinhas[0], cartinha);

            Assert.True(apadrinhamento.LocaisDeRecolhimento.Count > 1);
            Assert.Same(apadrinhamento.LocaisDeRecolhimento[0], localDeRecolhimento);
            Assert.Same(apadrinhamento.LocaisDeRecolhimento[1], localDeRecolhimento2);

        }
    }
}
