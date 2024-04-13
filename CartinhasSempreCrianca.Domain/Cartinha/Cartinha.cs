using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Domain.Cartinha
{
    public class Cartinha
    {
        public Guid Id { get; set; }
        public bool Disponivel { get; set; }
        public int Numero { get; set; }
        public string Pedido { get; set; }
        public DateTime Ano { get; set; }
        public string Desenho { get; set; }

        public Cartinha()
        {

        }

        public Cartinha(string pedido, int numero, DateTime ano, string desenho)
        {
            Disponivel = true;
            Pedido = pedido;
            Numero = numero;
            Ano = ano;
            Desenho = desenho;

        }
    }
}
