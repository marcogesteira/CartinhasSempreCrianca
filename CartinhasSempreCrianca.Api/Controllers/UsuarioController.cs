using CartinhasSempreCrianca.Application.Conta;
using CartinhasSempreCrianca.Application.Conta.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartinhasSempreCrianca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult GetPadrinhos()
        {
            var result = this._usuarioService.ObterPadrinho();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetPadrinhos(Guid id) 
        {
            var result = this._usuarioService.ObterPadrinhoPorId(id);
            if (result == null)
                return NotFound();
            
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Criar([FromBody] PadrinhoDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var result = this._usuarioService.CriarPadrinho(dto);

            return Created($"/padrinhos/{result.Id}", result);
        }

    }
}
