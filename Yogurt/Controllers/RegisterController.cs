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
        public async Task<IActionResult> Post([FromBody] InputRegisterControllerDto inputRegisterControllerDto)
        {
            var retorno = await _usuarioService.Register(inputRegisterControllerDto.Email, inputRegisterControllerDto.Password, inputRegisterControllerDto.UserName, inputRegisterControllerDto.Telefone);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Return.BadRequest))
            {
                return BadRequest(retorno.Message);
            }

            return Ok(retorno.Message);
        }
    }
}