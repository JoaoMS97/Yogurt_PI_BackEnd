using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EditarPerfilController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public EditarPerfilController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPatch("AlterarNomeUsuario")]
        public async Task<IActionResult> AlterarNomeUsuario(string nomeUsuario)
        {
            var retorno = await _usuarioService.AlterarNomeUsuario(nomeUsuario);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(retorno.Mensagem);
            }

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(retorno.Mensagem);
            }

            return Ok(retorno.Mensagem);
        }

        [HttpPatch("AlterarBiografia")]
        public async Task<IActionResult> AlterarBiografia(string biografia)
        {
            var retorno = await _usuarioService.AlterarBiografia(biografia);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(retorno.Mensagem);
            }

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(retorno.Mensagem);
            }

            return Ok(retorno.Mensagem);
        }

        [HttpPatch("AlterarFotoPerfil")]
        public async Task<IActionResult> AlterarFotoPerfil(string fotoPerfil)
        {
            var retorno = await _usuarioService.AlterarFotoPerfil(fotoPerfil);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(retorno.Mensagem);
            }

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(retorno.Mensagem);
            }

            return Ok(retorno.Mensagem);
        }

        [HttpPatch("AlterarCidade")]
        public async Task<IActionResult> AlterarCidade(string cidade)
        {
            var retorno = await _usuarioService.AlterarCidade(cidade);

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(retorno.Mensagem);
            }

            if (retorno.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(retorno.Mensagem);
            }

            return Ok(retorno.Mensagem);
        }
    }
}