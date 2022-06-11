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
        Task<RetornoDto> Register(string userName, string biography, DateTime dataNascimento, char genero, Guid idUsuario, byte[]? fotoPerfil);

        Task<RetornoDto> AlterUserName(string userName, Guid idPerfil);

        Task<RetornoDto> AlterBiography(string biography, Guid idPerfil);

        Task<RetornoDto> AlterProfilePhoto(byte[]? photoProfile, Guid idPerfil);

        Task<RetornoDto> AlterCity(string city, Guid idPerfil);
    }
}
