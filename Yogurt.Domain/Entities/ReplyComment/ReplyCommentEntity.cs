using Yogurt.Domain.Entities.Base;

namespace Yogurt.Domain.Entities.ReplyComment
{
    public class ReplyCommentEntity : EntityBase
    {
        public Guid IdComentarios { get; set; }

        public string? Legenda { get; set; }

        public DateTime DataCriacao { get; set; }

        public ReplyCommentEntity() { }

        public ReplyCommentEntity(Guid id_Comentarios, string? legenda, DateTime data_Criacao)
        {
            IdComentarios = id_Comentarios;
            Legenda = legenda;
            DataCriacao = data_Criacao;
        }

        public ReplyCommentEntity(string? legenda, DateTime data_Criacao)
        {
            Legenda = legenda;
            DataCriacao = data_Criacao;
        }
    }
}