using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    internal class Crianca
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pedido { get; set; }
        public bool Ativo { get; set; }
        public List<Cartinha> Cartinhas { get; set; } = new List<Cartinha>();

        public void AdicionarCartinha(Cartinha cartinha)
        {
            this.Cartinhas.Add(cartinha);
        }
    }
}
