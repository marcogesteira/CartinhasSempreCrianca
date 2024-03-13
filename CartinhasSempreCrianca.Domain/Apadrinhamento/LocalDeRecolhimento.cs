using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Apadrinhamento
{
    internal class LocalDeRecolhimento
    {
        public Guid Id { get; private set; }
        public string Endereco { get; private set; }
        public string Regiao { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Horario { get; private set; }
        public bool Ativo { get; private set; }

        public LocalDeRecolhimento(Guid id, string endereco, string regiao, string nome, string telefone, string horario)
        {
            Id = id;
            Endereco = endereco;
            Regiao = regiao;
            Nome = nome;
            Telefone = telefone;
            Horario = horario;
            Ativo = true;
        }
    }
}
