using Yogurt.Application.Dto;
using Yogurt.Domain.Entities;

namespace Yogurt.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<RetornoDto> Login(string email, string senha);

        Task<RetornoDto> SendToken(string email);

        Task<RetornoDto> Register(string email, string password, string userName, string telefone);

        Task<RetornoDto> VerifyToken(string token, string password);

    }
}
