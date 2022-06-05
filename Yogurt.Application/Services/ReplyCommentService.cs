using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Interfaces;
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


    }
}
