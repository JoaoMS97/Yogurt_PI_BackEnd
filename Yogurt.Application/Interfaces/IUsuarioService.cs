using Yogurt.Application.Dto;
using Yogurt.Domain.Entities;

namespace Yogurt.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<RetornoDto> RealizarLogin(string email, string? senha);

        Task<RetornoDto> AlterarSenha(string email);

        RetornoDto Inserir(string email, string password, string userName, string telefone);

        Task<RetornoDto> VerificarToken(Guid token);

    }
}
