using Yogurt.Application.Dto;

namespace Yogurt.Application.Interfaces;

public interface IPublicacaoService
{
    public Task<RetornoDto> Insert(string legenda, Guid usuarioId, Guid? comunidadeId);

    public Task<RetornoDto> GetById(Guid id);

    public Task<RetornoDto> GetAll();

    public Task<RetornoDto> GetByLegenda(string legenda);

    public Task<RetornoDto> Update(Guid id, string legenda);

    Task<RetornoDto> Delete(Guid id);

    public Task<int> IncrementarCurtidas(Guid id);
    
    public Task<int> DecrementarCurtidas(Guid id);

    public Task<RetornoDto> SharePublication(Guid id, Guid usuarioId);
}