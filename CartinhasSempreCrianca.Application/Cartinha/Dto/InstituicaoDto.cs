using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Cartinha.Dto
{
    public class InstituicaoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DiretorDto Diretor { get; set; }

        public List<CriancaDto> Criancas { get; set; } = new List<CriancaDto>();
    }
}
