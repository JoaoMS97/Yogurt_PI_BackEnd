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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository repository)
        {
            _commentRepository = repository;
        }

        public async Task<ReturnDto> InsertComment(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                return new ReturnDto("Não é possível enviar um comentario vazio", (int)StatusCodeEnum.Return.BadRequest);
            }

            if(comment.Length > 255)
            {
                return new ReturnDto("O comentarío não pode conter mais que 255 caracteres", (int)StatusCodeEnum.Return.BadRequest);
            }

            await _commentRepository.Insert(new CommentEntity(comment, int.MinValue, DateTime.Now));

            return new ReturnDto("Comentario enviado com sucesso!", (int)StatusCodeEnum.Return.Sucess);
        }

        public async Task<ReturnDto> InsertComment(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                return new ReturnDto("Não é possível enviar um comentario vazio", (int)StatusCodeEnum.Return.BadRequest);
            }

            if (comment.Length > 255)
            {
                return new ReturnDto("O comentarío não pode conter mais que 255 caracteres", (int)StatusCodeEnum.Return.BadRequest);
            }

            await _commentRepository.Insert(new CommentEntity(comment, int.MinValue, DateTime.Now));

            return new ReturnDto("Comentario enviado com sucesso!", (int)StatusCodeEnum.Return.Sucess);
        }
    }
}
