using CartinhasSempreCrianca.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Apadrinhamento
{
    public class Apadrinhamento
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Prazo { get; set; }
        public virtual Usuario Padrinho { get; set; }
        public virtual IList<Cartinha.Cartinha> Cartinhas { get; set; } = new List<Cartinha.Cartinha>();
        public virtual IList<LocalDeRecolhimento> LocaisDeRecolhimento { get; set; } = new List<LocalDeRecolhimento>();

        //public Apadrinhamento()
        //{
        //    Cartinhas = new List<Cartinha.Cartinha>();
        //    LocaisDeRecolhimento = new List<LocalDeRecolhimento>();

        //}

        public Apadrinhamento()
        {
            
        }

        public Apadrinhamento(DateTime data, DateTime prazo, Padrinho padrinho) //: base()
        {
            Data = data;
            Prazo = prazo;
            Padrinho = padrinho;
        }

        public void ApadrinharCartinha(Cartinha.Cartinha cartinha)
        {
            if (!cartinha.Disponivel)
                throw new Exception("Cartinha indisponível para apadrinhamento");

            this.Cartinhas.Add(cartinha);
        }
        public void EscolherLocal(LocalDeRecolhimento locais)
        {
            this.LocaisDeRecolhimento.Add(locais);
        }
    }
}
