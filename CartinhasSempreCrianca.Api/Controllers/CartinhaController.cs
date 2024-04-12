using CartinhasSempreCrianca.Application.Cartinha;
using CartinhasSempreCrianca.Application.Cartinha.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartinhasSempreCrianca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartinhaController : ControllerBase
    {
        private CartinhaService _cartinhaService;
        
        public CartinhaController(CartinhaService cartinhaService)
        {
            _cartinhaService = cartinhaService;
        }


        [HttpGet]
        public IActionResult GetCartinhas()
        {
            var result = this._cartinhaService.Obter();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCartinhas(Guid id)
        {
            var result = this._cartinhaService.Obter(id);

            if (result == null)
                return NotFound();
            
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] CartinhaDto dto)
        {
            if (ModelState is { IsValid: false})
                return BadRequest();

            var result = this._cartinhaService.Criar(dto);

            return Created($"/cartinha/{result.Id}", result);
        }
    }
}
