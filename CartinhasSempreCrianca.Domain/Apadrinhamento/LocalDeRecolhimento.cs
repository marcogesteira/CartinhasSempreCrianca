using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Apadrinhamento
{
    internal class LocalDeRecolhimento
    {
        public Guid Id { get; set; }
        public string Endereco { get; set; }
        public string Regiao { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Horario { get; set; }
        public bool Ativo { get; set; }

    }
}
