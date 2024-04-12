using CartinhasSempreCrianca.Domain.Apadrinhamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Repository
{
    public class LocalDeRecolhimentoRepository : RepositoryBase<LocalDeRecolhimento>
    {
        public LocalDeRecolhimentoRepository(CartinhasSempreCriancaContext context) : base(context)
        {
        }
    }
}
