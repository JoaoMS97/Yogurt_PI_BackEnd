using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Dto;

namespace Yogurt.Application.Interfaces
{
    public interface IProfileUserService
    {
        Task<ReturnDto> Register(string userName, string biography, DateTime dataNascimento, char genero, Guid idUsuario, byte[]? fotoPerfil);

        Task<ReturnDto> AlterUserName(string userName, Guid idPerfil);

        Task<ReturnDto> AlterBiography(string biography, Guid idPerfil);

        Task<ReturnDto> AlterProfilePhoto(byte[]? photoProfile, Guid idPerfil);

        Task<ReturnDto> AlterCity(string city, Guid idPerfil);
    }
}
