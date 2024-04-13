using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Apadrinhamento.Dto
{
    public class LocalDeRecolhimentoDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Regiao { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Horario { get; set; }
        public bool Ativo { get; set; }

    }
}
