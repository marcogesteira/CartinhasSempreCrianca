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
    internal class CartinhaService
    {
        private CartinhaRepository cartinhaRepository { get; set; }

        public CartinhaService(CartinhaRepository cartinhaRepository)
        {
            this.cartinhaRepository = cartinhaRepository;
        }

        public CartinhaDto Criar(CartinhaDto dto)
        {
            Domain.Cartinha.Cartinha cartinha = this.CartinhaDtoParaCartinha(dto);
            this.cartinhaRepository.Save(cartinha);

            return this.CartinhaParaCartinhaDto(cartinha);
        }

        public CartinhaDto Obter(Guid id)
        {
            var cartinha = this.cartinhaRepository.GetById(id);
            
            return this.CartinhaParaCartinhaDto(cartinha);
        }

        public CartinhaDto Atualizar(CartinhaDto dto)
        {
            Domain.Cartinha.Cartinha cartinha = this.CartinhaDtoParaCartinha(dto);
            this.cartinhaRepository.Update(cartinha);

            return this.CartinhaParaCartinhaDto(cartinha);
        }

        public CartinhaDto Deletar(CartinhaDto dto)
        {
            Domain.Cartinha.Cartinha cartinha = this.CartinhaDtoParaCartinha(dto);
            this.cartinhaRepository.Delete(cartinha);

            return this.CartinhaParaCartinhaDto(cartinha);
        }


        private Domain.Cartinha.Cartinha CartinhaDtoParaCartinha(CartinhaDto dto)
        {
            Domain.Cartinha.Cartinha cartinha = new Domain.Cartinha.Cartinha()
            {
                Id = dto.Id,
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
