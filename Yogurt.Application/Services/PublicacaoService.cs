using Yogurt.Application.Dto;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Infraestructure.Interfaces;

namespace Yogurt.Application.Services;

public class PublicacaoService : IPublicacaoService
{
    private readonly IPublicacaoRepository _publicacaoRepository;

    public PublicacaoService(IPublicacaoRepository publicacaoRepository)
    {
        _publicacaoRepository = publicacaoRepository;
    }

    public async Task<RetornoDto> Insert(string? legenda, Guid usuarioId, Guid? comunidadeId)
    {
        var entity =
            InputParaPublicacaoEntity.ConverterInputParaPublicacaoEntity(legenda ?? string.Empty, usuarioId,
                comunidadeId);
        
        await _publicacaoRepository.Insert(entity);

        return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);
    }

    public async Task<RetornoDto> GetById(Guid id)
    {
        var publicacao = await _publicacaoRepository.GetById(id);

        if (publicacao == null)
            return new RetornoDto("Publicação não encontrada", (int)StatusCodeEnum.Retorno.NotFound);

        return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso, publicacao);
    }

    public async Task<RetornoDto> GetAll()
    {
        var listaDePublicacao = await _publicacaoRepository.GetAll();

        if (listaDePublicacao.Any())
            return new RetornoDto("Publicações não encontradas", (int)StatusCodeEnum.Retorno.NotFound);
        
        return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso, listaDePublicacao);
    }

    public async Task<RetornoDto> GetByLegenda(string legenda)
    {
        var listaDePublicacoes = await _publicacaoRepository.GetByLegenda(legenda);
        
        if (listaDePublicacoes.Any())
            return new RetornoDto("Publicação(ões) não encontrada(as)", 
                (int)StatusCodeEnum.Retorno.NotFound);
        
        return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso, listaDePublicacoes);
    }

    public async Task<RetornoDto> Update(Guid id, string legenda)
    {
        var atualizado = await _publicacaoRepository.Update(id, legenda);

        if (!atualizado)
            return new RetornoDto("Não foi possível atualizar, tente novamente",
                (int)StatusCodeEnum.Retorno.BadRequest);

        var publicacaoAtualizada = await _publicacaoRepository.GetById(id);

        if (publicacaoAtualizada == null)
            return new RetornoDto("Algo de errado aconteceu, tente novamente",
                (int)StatusCodeEnum.Retorno.BadRequest);

        return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso, publicacaoAtualizada);
    }

    public async Task<RetornoDto> Delete(Guid id)
    {
        var deletar = await _publicacaoRepository.Delete(id);

        return deletar
            ? new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso)
            : new RetornoDto("Não foi possível deletar", (int)StatusCodeEnum.Retorno.BadRequest);
    }

    public async Task<int> IncrementarCurtidas(Guid id)
    {
        var publicacao = await _publicacaoRepository.GetById(id);
        if (publicacao == null)
            throw new InvalidOperationException(
                "Não foi possível realizar essa operação, recarregue a página e tente novamente");

        return _publicacaoRepository.IncrementarCurtidas(publicacao);
    }

    public async Task<int> DecrementarCurtidas(Guid id)
    {
        var publicacao = await _publicacaoRepository.GetById(id);
        if (publicacao == null)
            throw new InvalidOperationException(
                "Não foi possível realizar essa operação, recarregue a página e tente novamente");

        return _publicacaoRepository.DecrementarCurtidas(publicacao);
    }

    public async Task<RetornoDto> SharePublication(Guid id)
    {
        var publication = await _publicacaoRepository.GetById(id);

        if (publication == null)
            return new RetornoDto("Essa publicação não existe mais", (int)StatusCodeEnum.Retorno.NotFound);

        publication.Curtidas = 0;
        publication.DataCriacao = DateTime.Now;
        
        //setar o novo usuario
        //publication.UsuarioId =  ;

        await _publicacaoRepository.Insert(publication);

        return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);
    }
}