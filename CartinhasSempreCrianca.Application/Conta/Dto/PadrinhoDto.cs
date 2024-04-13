using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Conta.Dto
{
    public class PadrinhoDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public bool Newsletter { get; set; }
        public bool BomPadrinho { get; set; }
        public bool Ativo { get; set; }
    }
}
