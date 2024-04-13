using CartinhasSempreCrianca.Application.Apadrinhamento.Dto;
using CartinhasSempreCrianca.Domain.Apadrinhamento;
using CartinhasSempreCrianca.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Apadrinhamento
{
    public class ApadrinhamentoService
    {
        private LocalDeRecolhimentoRepository LocalDeRecolhimentoRepository { get; set; }
        private ApadrinhamentoRepository ApadrinhamentoRepository { get; set; }

        public ApadrinhamentoService(LocalDeRecolhimentoRepository localDeRecolhimentoRepository, ApadrinhamentoRepository apadrinhamentoRepository)
        {
            LocalDeRecolhimentoRepository = localDeRecolhimentoRepository;
            ApadrinhamentoRepository = apadrinhamentoRepository;
        }

        public LocalDeRecolhimentoDto Criar(LocalDeRecolhimentoDto dto)
        {
            var local = this.LocalDeRecolhimentoDtoParaLocalDeRecolhimento(dto);
            this.LocalDeRecolhimentoRepository.Save(local);

            return this.LocalDeRecolhimentoParaLocalDeRecolhimentoDto(local);
        }

        public LocalDeRecolhimentoDto Obter(Guid id)
        {
            var local = this.LocalDeRecolhimentoRepository.GetById(id);
            return this.LocalDeRecolhimentoParaLocalDeRecolhimentoDto(local);
        }

        public IEnumerable<LocalDeRecolhimentoDto> Obter()
        {
            var local = this.LocalDeRecolhimentoRepository.GetAll();
            List<LocalDeRecolhimentoDto> dto = new List<LocalDeRecolhimentoDto>();

            foreach (var item in local)
            {
                dto.Add(this.LocalDeRecolhimentoParaLocalDeRecolhimentoDto(item));
            }
            return dto;
        }

        private LocalDeRecolhimento LocalDeRecolhimentoDtoParaLocalDeRecolhimento(LocalDeRecolhimentoDto dto)
        {
            LocalDeRecolhimento localDeRecolhimento = new LocalDeRecolhimento()
            {
                Endereco = dto.Endereco,
                Regiao = dto.Regiao,
                Nome = dto.Nome,
                Horario = dto.Horario,
                Telefone = dto.Telefone,
                Ativo = dto.Ativo,
            };
            return localDeRecolhimento;
        }

        private LocalDeRecolhimentoDto LocalDeRecolhimentoParaLocalDeRecolhimentoDto(LocalDeRecolhimento localDeRecolhimento)
        {
            LocalDeRecolhimentoDto dto = new LocalDeRecolhimentoDto()
            {
                Id = localDeRecolhimento.Id,
                Endereco = localDeRecolhimento.Endereco,
                Regiao = localDeRecolhimento.Regiao,
                Nome = localDeRecolhimento.Nome,
                Horario = localDeRecolhimento.Horario,
                Telefone = localDeRecolhimento.Telefone,
                Ativo = localDeRecolhimento.Ativo,
            };
            return dto;
        }
    }
}
