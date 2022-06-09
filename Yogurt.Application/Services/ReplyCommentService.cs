using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Dto;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Interfaces;

namespace Yogurt.Application.Services
{
    public class ReplyCommentService : IReplyCommentService
    {
        private readonly IReplyCommentRepository _replyCommentRepository;

        public ReplyCommentService(IReplyCommentRepository repository)
        {
            _replyCommentRepository = repository;
        }

        public async Task<ReturnDto> InsertReplyComment(Guid idComment, string response)
        {
            if (idComment == Guid.Empty)
            {
                return new ReturnDto("Id da publicação não encontrado!", (int)StatusCodeEnum.Return.BadRequest);
            }

            if (string.IsNullOrEmpty(response))
            {
                return new ReturnDto("Não é possível enviar um comentario vazio", (int)StatusCodeEnum.Return.BadRequest);
            }

            if (response.Length > 255)
            {
                return new ReturnDto("O comentarío não pode conter mais que 255 caracteres", (int)StatusCodeEnum.Return.BadRequest);
            }

            await _replyCommentRepository.Insert(new ReplyCommentEntity(response, DateTime.Now));

            return new ReturnDto("Resposta do Comentario enviado com sucesso!", (int)StatusCodeEnum.Return.Sucess);
        }
    }
}
