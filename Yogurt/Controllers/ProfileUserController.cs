using Microsoft.AspNetCore.Mvc;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Dto;

namespace Yogurt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileUserController : ControllerBase
    {
        private readonly IProfileUserService _profileUserService;

        public ProfileUserController(IProfileUserService profileUserService)
        {
            _profileUserService = profileUserService;
        }

        [HttpPost("RegisterProfileUser")]
        public async Task<IActionResult> Post([FromBody] InputProfileUserDto inputProfileUserDto)
        {
            var returns = await _profileUserService.Register(inputProfileUserDto.Nome, inputProfileUserDto.Biografia, inputProfileUserDto.DataNascimento, inputProfileUserDto.Genero, inputProfileUserDto.IdUsuario, inputProfileUserDto.FotoPerfil);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(returns);
            }

            return Ok(returns);
        }

        [HttpPatch("AlterNameUser")]
        public async Task<IActionResult> AlterNameUser(string nameUser, Guid idPerfil)
        {
            var returns = await _profileUserService.AlterUserName(nameUser, idPerfil);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(returns.Mensagem);
            }

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(returns.Mensagem);
            }

            return Ok(returns.Mensagem);
        }

        [HttpPatch("AlterBiography")]
        public async Task<IActionResult> AlterBiography(string? biography, Guid idPerfil)
        {
            var returns = await _profileUserService.AlterBiography(biography, idPerfil);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(returns.Mensagem);
            }

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(returns.Mensagem);
            }

            return Ok(returns.Mensagem);
        }

        [HttpPatch("AlterPhotoProfile")]
        public async Task<IActionResult> AlterProfilePhoto(byte[]? photoProfile, Guid idPerfil)
        {
            var returns = await _profileUserService.AlterProfilePhoto(photoProfile, idPerfil);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(returns.Mensagem);
            }

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(returns.Mensagem);
            }

            return Ok(returns.Mensagem);
        }

        [HttpPatch("AlterCity")]
        public async Task<IActionResult> AlterCity(string city, Guid idPerfil)
        {
            var returns = await _profileUserService.AlterCity(city, idPerfil);

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.BadRequest))
            {
                return BadRequest(returns.Mensagem);
            }

            if (returns.StatusCode.Equals((int)StatusCodeEnum.Retorno.NotFound))
            {
                return NotFound(returns.Mensagem);
            }

            return Ok(returns.Mensagem);
        }
    }
}