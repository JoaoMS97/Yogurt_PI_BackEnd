namespace Yogurt.Domain.Entities
{
    public class ReplyCommentEntity : EntityBase
    {
        public Guid Id_Resposta { get; set; }

        public Guid Id_Comentarios { get; set; }

        public string? Legenda { get; set; }

        public DateTime Data_Criacao { get; set; }

        public ReplyCommentEntity()
        {
            Id_Resposta = Guid.NewGuid();
        }

        public ReplyCommentEntity(Guid id_Comentarios, string? legenda, DateTime data_Criacao)
        {
            Id_Comentarios = id_Comentarios;
            Legenda = legenda;
            Data_Criacao = data_Criacao;
        }

        public ReplyCommentEntity(string? legenda, DateTime data_Criacao)
        {
            Legenda = legenda;
            Data_Criacao = data_Criacao;
        }
    }
}