using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Apadrinhamento
{
    public class LocalDeRecolhimento
    {
        public Guid Id { get; set; }
        public string Endereco { get; set; }
        public string Regiao { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Horario { get; set; }
        public bool Ativo { get; set; }

        public LocalDeRecolhimento()
        {
            
        }

        public LocalDeRecolhimento(string endereco, string regiao, string nome, string telefone, string horario)
        {
            Endereco = endereco;
            Regiao = regiao;
            Nome = nome;
            Telefone = telefone;
            Horario = horario;
            Ativo = true;
        }
    }
}
