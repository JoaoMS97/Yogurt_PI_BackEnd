using Yogurt.Application.Dto;

namespace Yogurt.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<RetornoDto> RealizarLogin(string email, string? senha);

        Task<RetornoDto> AlterarSenha(string email);

        RetornoDto Inserir(string? email, string? senha);

        Task<RetornoDto> GetById(Guid id);

        Task<RetornoDto> VerificarToken(Guid token);

    }
}
