using CartinhasSempreCrianca.Domain.Cartinha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Repository
{
    public class CartinhaRepository : RepositoryBase<Cartinha>
    {
        public CartinhaRepository(CartinhasSempreCriancaContext context) : base(context)
        {
        }
    }
}
