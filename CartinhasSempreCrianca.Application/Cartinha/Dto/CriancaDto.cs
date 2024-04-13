using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Cartinha.Dto
{
    public class CriancaDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        public bool Ativo { get; set; }

        public List<CartinhaDto> Cartinhas { get; set; } = new List<CartinhaDto>();
    }
}
