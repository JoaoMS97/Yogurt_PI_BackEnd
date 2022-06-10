using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Interfaces.BaseInterface;

namespace Yogurt.Infraestructure.Interfaces
{
    public interface IFileRepository : IRepositoryAsync<FileEntity>   
    {
    }
}
