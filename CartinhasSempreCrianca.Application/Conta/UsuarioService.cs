using CartinhasSempreCrianca.Application.Conta.Dto;
using CartinhasSempreCrianca.Domain.Conta;
using CartinhasSempreCrianca.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Conta
{
    public class UsuarioService
    {
        private PadrinhoRepository PadrinhoRepository { get; set; }
        private ModeradorRepository ModeradorRepository { get; set;}

        public UsuarioService(PadrinhoRepository padrinhoRepository, ModeradorRepository moderadorRepository)
        {
            PadrinhoRepository = padrinhoRepository;
            ModeradorRepository = moderadorRepository;
        }

        public PadrinhoDto CriarPadrinho(PadrinhoDto dto)
        {
            Padrinho padrinho = this.PadrinhoDtoParaPadrinho(dto);
            this.PadrinhoRepository.Save(padrinho);

            return this.PadrinhoParaPadrinhoDto(padrinho);
        }

        public PadrinhoDto ObterPadrinhoPorId(Guid id)
        {
            var padrinho = this.PadrinhoRepository.GetById(id);
            return this.PadrinhoParaPadrinhoDto(padrinho);
        }

        public IEnumerable<PadrinhoDto> ObterPadrinho()
        {
            var padrinho = this.PadrinhoRepository.GetAll();
            List<PadrinhoDto> dto = new List<PadrinhoDto>();

            foreach (var item in padrinho)
            {
                dto.Add(this.PadrinhoParaPadrinhoDto(item));
            }
            return dto;
        }


        private Padrinho PadrinhoDtoParaPadrinho(PadrinhoDto dto)
        {
            Padrinho padrinho = new Padrinho()
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Senha = dto.Senha,
                Telefone = dto.Telefone,
                Newsletter = dto.Newsletter,
            };
            return padrinho;
        }
        private PadrinhoDto PadrinhoParaPadrinhoDto(Padrinho padrinho)
        {
            PadrinhoDto dto = new PadrinhoDto();
            dto.Id = padrinho.Id;
            dto.Nome = padrinho.Nome;
            dto.Email = padrinho.Email;
            dto.Senha = "xxxxxxxx";
            dto.Telefone = padrinho.Telefone;
            dto.Newsletter = padrinho.Newsletter;
            dto.BomPadrinho = padrinho.BomPadrinho;
            
            return dto;
        }
    }
}
