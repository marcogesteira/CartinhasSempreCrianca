using CartinhasSempreCrianca.Application.Cartinha.Dto;
using CartinhasSempreCrianca.Domain.Cartinha;
using CartinhasSempreCrianca.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Application.Cartinha
{
    public class InstituicaoService
    {
        private InstituicaoRepository InstituicaoRepository { get; set; }
        private CriancaRepository CriancaRepository { get; set; }
        private CartinhaRepository CartinhaRepository { get; set; }

        public InstituicaoService(InstituicaoRepository instituicaoRepository, CriancaRepository criancaRepository, CartinhaRepository cartinhaRepository)
        {
            InstituicaoRepository = instituicaoRepository;
            CriancaRepository = criancaRepository;
            CartinhaRepository = cartinhaRepository;
        }

        public InstituicaoDto Criar(InstituicaoDto instituicaoDto)
        {
            Instituicao instituicao = this.InstituicaoDtoParaInstituicao(instituicaoDto);
            this.InstituicaoRepository.Save(instituicao);

            return this.InstituicaoParaInstituicaoDto(instituicao);
        }

        public InstituicaoDto Obter(Guid id)
        {
            var instituicao = this.InstituicaoRepository.GetById(id);
            return this.InstituicaoParaInstituicaoDto(instituicao);
        }

        public IEnumerable<InstituicaoDto> Obter()
        {
            var instituicao = this.InstituicaoRepository.GetAll();
            List<InstituicaoDto> dto = new List<InstituicaoDto>();

            foreach (var item in instituicao)
            {
                dto.Add(this.InstituicaoParaInstituicaoDto(item));
            }

            return dto;
        }

        public CriancaDto AssociarCrianca(CriancaDto dto)
        {
            var instituicao = this.InstituicaoRepository.GetById(dto.InstituicaoId);

            if (instituicao == null)
                throw new Exception("Instituição não encontrada");

            var novaCrianca = this.CriancaDtoParaCrianca(dto);

            instituicao.AdicionarCrianca(novaCrianca);

            this.InstituicaoRepository.Update(instituicao);

            var result = this.CriancaParaCriancaDto(novaCrianca);

            return result;
        }

        public CartinhaDto AssociarCartinha(CartinhaDto dto)
        {
            var crianca = this.CriancaRepository.GetById(dto.CriancaId);

            if (crianca == null)
                throw new Exception("Criança não encontrada");

            var novaCartinha = this.CartinhaDtoParaCartinha(dto);

            crianca.AdicionarCartinha(novaCartinha);

            this.CriancaRepository.Update(crianca);

            var result = this.CartinhaParaCartinhaDto(novaCartinha);

            return result;
        }


        private Instituicao InstituicaoDtoParaInstituicao(InstituicaoDto dto)
        {
            Instituicao instituicao = new Instituicao()
            {
                Nome = dto.Nome,
                Ativo = dto.Ativo,
                Diretor = this.DiretorDtoParaDiretor(dto.Diretor)
            };

            foreach (CriancaDto item in dto.Criancas)
            {
                instituicao.AdicionarCrianca(new Crianca
                {
                    Nome = item.Nome,
                    Idade = item.Idade,
                    Ativo = item.Ativo
                });
            }
            return instituicao;
        }

        private InstituicaoDto InstituicaoParaInstituicaoDto(Instituicao instituicao)
        {
            InstituicaoDto dto = new InstituicaoDto();
            dto.Id = instituicao.Id;
            dto.Nome = instituicao.Nome;
            dto.Ativo = instituicao.Ativo;
            dto.Diretor = this.DiretorParaDiretorDto(instituicao.Diretor);

            foreach (var item in instituicao.Criancas)
            {
                var criancaDto = new CriancaDto()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Idade = item.Idade,
                    Ativo = item.Ativo,
                };
                dto.Criancas.Add(criancaDto);
            }
            return dto;
        }

        private Diretor DiretorDtoParaDiretor(DiretorDto dto)
        {
            Diretor diretor = new Diretor()
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Telefone = dto.Telefone,
            };

            return diretor;
        }

        private DiretorDto DiretorParaDiretorDto(Diretor diretor)
        {
            DiretorDto dto = new DiretorDto()
            {
                Id = diretor.Id,
                Nome = diretor.Nome,
                Email = diretor.Email,
                Telefone = diretor.Telefone,
            };

            return dto;
        }


        private Crianca CriancaDtoParaCrianca(CriancaDto dto)
        {
            Crianca crianca = new Crianca()
            {
                Nome = dto.Nome,
                Idade = dto.Idade,
                Ativo = dto.Ativo,
            };
            foreach (CartinhaDto item in dto.Cartinhas)
            {
                crianca.AdicionarCartinha(new Domain.Cartinha.Cartinha
                {
                    Disponivel = item.Disponivel,
                    Numero = item.Numero,
                    Desenho = item.Desenho,
                    Ano = item.Ano,
                    Pedido = item.Pedido,
                });
            }

            return crianca;
        }

        private CriancaDto CriancaParaCriancaDto(Crianca crianca)
        {
            CriancaDto dto = new CriancaDto();
            dto.Id = crianca.Id;
            dto.Nome = crianca.Nome;
            dto.Idade = crianca.Idade;
            dto.Ativo = crianca.Ativo;

            foreach (var item in crianca.Cartinhas)
            {
                var cartinhaDto = new CartinhaDto()
                {
                    Id = item.Id,
                    Disponivel = item.Disponivel,
                    Numero = item.Numero,
                    Ano = item.Ano,
                    Desenho = item.Desenho,
                };

                dto.Cartinhas.Add(cartinhaDto);
            }
            return dto;
        }

        private Domain.Cartinha.Cartinha CartinhaDtoParaCartinha(CartinhaDto dto)
        {
            Domain.Cartinha.Cartinha cartinha = new Domain.Cartinha.Cartinha()
            {
                Numero = dto.Numero,
                Pedido = dto.Pedido,
                Ano = dto.Ano,
                Desenho = dto.Desenho,
                Disponivel = dto.Disponivel
            };

            return cartinha;
        }

        private CartinhaDto CartinhaParaCartinhaDto(Domain.Cartinha.Cartinha cartinha)
        {
            CartinhaDto dto = new CartinhaDto()
            {
                Id = cartinha.Id,
                Numero = cartinha.Numero,
                Pedido = cartinha.Pedido,
                Ano = cartinha.Ano,
                Desenho = cartinha.Desenho,
                Disponivel = cartinha.Disponivel
            };

            return dto;
        }
    }
}
