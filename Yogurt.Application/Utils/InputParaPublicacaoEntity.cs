using Yogurt.Domain.Entities;

namespace Yogurt.Application.Utils;

public static class InputParaPublicacaoEntity
{
    public static PublicacaoEntity ConverterInputParaPublicacaoEntity(string legenda, Guid usuarioId, Guid? comunidadeId)
    {
        return new PublicacaoEntity
        {
            Legenda = legenda,
            UsuarioId = usuarioId,
            ComunidadeId = comunidadeId,
            Curtidas = 0,
            DataCriacao = DateTime.Now
        };
    }
}