using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Cartinha.Dto
{
    public class CartinhaDto
    {
        public Guid Id { get; set; }
        public Guid CriancaId { get; set; }
        public bool Disponivel { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Pedido { get; set; }
        [Required]
        public DateTime Ano { get; set; }
        [Required]
        public string Desenho { get; set; }
    }
}
