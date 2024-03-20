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
        public Usuario Padrinho { get; set; }
        public List<Cartinha.Cartinha> Cartinhas { get; set; } = new List<Cartinha.Cartinha>();
        public List<LocalDeRecolhimento> LocaisDeRecolhimento { get; set; } = new List<LocalDeRecolhimento>();

        //public Apadrinhamento()
        //{
        //    Cartinhas = new List<Cartinha.Cartinha>();
        //    LocaisDeRecolhimento = new List<LocalDeRecolhimento>();

        //}

        public Apadrinhamento(DateTime data, DateTime prazo, Padrinho padrinho) //: base()
        {
            Data = data;
            Prazo = prazo;
            Padrinho = padrinho;
        }

        public void AdicionarCartinha(Cartinha.Cartinha cartinha)
        {
            this.Cartinhas.Add(cartinha);
        }
        public void AdicionarLocal(LocalDeRecolhimento locais)
        {
            this.LocaisDeRecolhimento.Add(locais);
        }
    }
}
