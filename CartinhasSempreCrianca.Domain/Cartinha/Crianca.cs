using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    public class Crianca
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
        public List<Cartinha> Cartinhas { get; set; } = new List<Cartinha>();

        public Crianca(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Ativo = true;
        }

        public void AdicionarCartinha(Cartinha cartinha)
        {
            this.Cartinhas.Add(cartinha);
        }
    }
}
