using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Interfaces;
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


    }
}
