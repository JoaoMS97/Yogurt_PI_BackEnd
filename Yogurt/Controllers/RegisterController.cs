using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public RegisterController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("Registrar")]
        public IActionResult Post([FromBody] InputLoginDto inputLoginDto)
        {
            var retorno = _usuarioService.Inserir(inputLoginDto.Email, inputLoginDto.Password);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
                return BadRequest(retorno.Mensagem);

            return Ok(retorno.Mensagem); 
        }

        [HttpGet("GetRegistroById")]
        public async Task<IActionResult> GetById(Guid? id)
        {
            var retorno = await _usuarioService.GetById(id.GetValueOrDefault());

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.Sucesso))
            {
                return Ok(retorno.Objeto);
            }

            return BadRequest(retorno.Mensagem);
        }
    }
}