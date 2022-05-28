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
        public IActionResult Post([FromBody] InputRegisterControllerDto inputRegisterControllerDto)
        {
            var retorno = _usuarioService.Inserir(inputRegisterControllerDto.Email, inputRegisterControllerDto.Password, inputRegisterControllerDto.UserName, inputRegisterControllerDto.Telefone);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
                return BadRequest(retorno.Mensagem);

            return Ok(retorno.Mensagem); 
        }
    }
}