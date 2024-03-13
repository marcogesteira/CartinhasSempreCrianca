using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    internal class Cartinha
    {
        public Guid Id { get; private set; }
        public bool Disponivel { get; private set; }
        public int Numero { get; set; }
        public DateTime Ano { get; set; }
        public string Desenho { get; set; }

        public Cartinha(Guid id, bool disponivel, int numero, DateTime ano, string desenho)
        {
            Id = id;
            Disponivel = disponivel;
            Numero = numero;
            Ano = ano;
            Desenho = desenho;
        }
    }
}
