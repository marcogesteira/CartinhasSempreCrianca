using CartinhasSempreCrianca.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Repository
{
    public class ModeradorRepository : RepositoryBase<Moderador>
    {
        public ModeradorRepository(CartinhasSempreCriancaContext context) : base(context)
        {
        }
    }
}
