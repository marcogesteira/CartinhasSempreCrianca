using CartinhasSempreCrianca.Application.Apadrinhamento.Dto;
using CartinhasSempreCrianca.Application.Apadrinhamento;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartinhasSempreCrianca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalDeRecolhimentoController : ControllerBase
    {
        private ApadrinhamentoService _apadrinhamentoService;

        public LocalDeRecolhimentoController(ApadrinhamentoService apadrinhamentoService)
        {
            _apadrinhamentoService = apadrinhamentoService;
        }

        [HttpGet]
        public IActionResult GetLocalDeRecolhimento()
        {
            var result = this._apadrinhamentoService.Obter();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetLocalDeRecolhimento(Guid id)
        {
            var result = this._apadrinhamentoService.Obter(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpPost]
        public IActionResult Criar([FromBody] LocalDeRecolhimentoDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var result = this._apadrinhamentoService.Criar(dto);

            return Created($"/apadrinhamento/{result.Id}", result);
        }
    }
}
