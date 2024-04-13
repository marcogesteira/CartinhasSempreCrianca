using CartinhasSempreCrianca.Application.Cartinha;
using CartinhasSempreCrianca.Application.Cartinha.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartinhasSempreCrianca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController : ControllerBase
    {
        private InstituicaoService _instituicaoService;

        public InstituicaoController(InstituicaoService instituicaoService)
        {
            _instituicaoService = instituicaoService;
        }

        [HttpGet]
        public IActionResult GetInstituicoes()
        {
            var result = this._instituicaoService.Obter();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetInstituicoes(Guid id)
        {
            var result = this._instituicaoService.Obter(id);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] InstituicaoDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var result = this._instituicaoService.Criar(dto);

            return Created($"/instituicao/{result.Id}", result);
        }

        [HttpGet("{idInstituicao}/criancas")]
        public IActionResult ObterCriancas(Guid idInstituicao)
        {
            var result = this._instituicaoService.ObterCrianca(idInstituicao);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{idInstituicao}/criancas/{id}")]
        public IActionResult ObterCriancaPorId(Guid idInstituicao, Guid id)
        {
            var result = this._instituicaoService.ObterCriancaPorId(idInstituicao, id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("{id}/criancas")]
        public IActionResult AssociarCrianca([FromBody] CriancaDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var result = this._instituicaoService.AssociarCrianca(dto);

            return Created($"/instituicao/{result.InstituicaoId}/criancas/{result.Id}", result);
        }

        [HttpGet("{idCrianca}/cartinhas")]
        public IActionResult ObterCartinhas(Guid idCrianca)
        {
            var result = this._instituicaoService.ObterCartinha(idCrianca);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{idCrianca}/cartinhas/{id}")]
        public IActionResult ObterCartinhaPorId(Guid idCrianca, Guid id)
        {
            var result = this._instituicaoService.ObterCartinhaPorId(idCrianca, id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
