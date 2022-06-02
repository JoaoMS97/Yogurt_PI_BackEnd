﻿using Yogurt.Domain.Entities;

namespace Yogurt.Infraestructure.Interfaces;

public interface IPublicacaoRepository : IRepositoryAsync<PublicacaoEntity>
{
    public Task<List<PublicacaoEntity>> GetByLegenda(string legenda);

    public Task<bool> Update(Guid id, string legenda);

    public Task<List<PublicacaoEntity>> GetAll();

    public Task<bool> Delete(Guid id);
    
    int IncrementarCurtidas(PublicacaoEntity publicacaoEntity);
    
    int DecrementarCurtidas(PublicacaoEntity publicacao);
}