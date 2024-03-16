using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    public class Instituicao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<Crianca> Criancas { get; set; } = new List<Crianca>();

        public Instituicao(string nome)
        {
            Nome = nome;
            Ativo = true;
        }

        public void AdicionarCrianca(Crianca crianca)
        {
            this.Criancas.Add(crianca);
        }
    }
}
