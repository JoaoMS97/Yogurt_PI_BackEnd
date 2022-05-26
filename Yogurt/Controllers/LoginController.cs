using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("Logar")]
        public async Task <IActionResult> Logar(string email, string? senha)
        {
            var retorno = await _usuarioService.RealizarLogin(email, senha);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
                return NotFound(retorno.Mensagem);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
                return BadRequest(retorno.Mensagem);

            return Ok(retorno.Mensagem);
        }

        [HttpPost("ValidarToken")]
        public async Task<IActionResult> ValidarToken(Guid token)
        {
            var retorno = await _usuarioService.VerificarToken(token);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
                return NotFound(retorno.Mensagem);

            return Ok(retorno.Mensagem);
        }
        
        
        [HttpPatch("AlterarSenha")]
        public async Task<IActionResult> AlterarSenha(string email, [FromBody] InputLoginDto inputLoginDto)
        {
            var retorno = await _usuarioService.AlterarSenha(email);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
                return BadRequest(retorno.Mensagem);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
                return NotFound(retorno.Mensagem);

            return Ok(retorno.Mensagem);
        }
    }
}
