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
    }
}
