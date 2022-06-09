using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Dto;

namespace Yogurt.Application.Interfaces
{
    public interface ICommentService
    {
        Task<ReturnDto> InsertComment(string Legenda);
    }
}
