using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartinhasSempreCrianca.Domain.Cartinha;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class CartinhaTests
    {
        [Fact]
        public void DeveCriarCartinhaComSucesso()
        {
            Cartinha cartinha = new Cartinha("Carrinho", 1050, DateTime.Now, "www.test.com");
        }
    }
}
