using Yogurt.Domain.Entities.Publication;

namespace Yogurt.Application.Utils;

public static class InputParaPublicacaoEntity
{
    public static PublicacaoEntity ConverterInputParaPublicacaoEntity(string legenda, Guid usuarioId, Guid? comunidadeId)
    {
        return new PublicacaoEntity
        {
            Legenda = legenda,
            Id_Perfil = usuarioId,
            Id_Comunidade = comunidadeId,
            Curtidas = 0,
            Data_Criacao = DateTime.Now
        };
    }
}