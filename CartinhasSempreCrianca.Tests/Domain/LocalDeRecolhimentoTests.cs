using CartinhasSempreCrianca.Domain.Apadrinhamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Tests.Domain
{
    public class LocalDeRecolhimentoTests
    {
        [Fact]
        public void DeveCriarLocalDeRecolhimentoComSucesso()
        {
            LocalDeRecolhimento localDeRecolhimento = new LocalDeRecolhimento("Rua das Couves, 35", "Centro", "Joaquim", "2199988-9888", "Das 14h às 18h");
        }
    }
}
