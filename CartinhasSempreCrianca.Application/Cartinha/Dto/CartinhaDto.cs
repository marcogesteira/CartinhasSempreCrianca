using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Cartinha.Dto
{
    public class CartinhaDto
    {
        public Guid Id { get; set; }
        public bool Disponivel { get; set; }
        public int Numero { get; set; }
        public string Pedido { get; set; }
        public DateTime Ano { get; set; }
        public string Desenho { get; set; }
    }
}
