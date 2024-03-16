using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    public class Cartinha
    {
        public Guid Id { get; private set; }
        public bool Disponivel { get; private set; }
        public int Numero { get; set; }
        public DateTime Ano { get; set; }
        public string Desenho { get; set; }

        public Cartinha(int numero, DateTime ano, string desenho)
        {
            Disponivel = true;
            Numero = numero;
            Ano = ano;
            Desenho = desenho;
        }
    }
}
