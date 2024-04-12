using CartinhasSempreCrianca.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Repository
{
    public class PadrinhoRepository : RepositoryBase<Padrinho>
    {
        public PadrinhoRepository(CartinhasSempreCriancaContext context) : base(context)
        {
        }
    }
}
