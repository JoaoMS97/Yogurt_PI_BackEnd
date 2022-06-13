using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;
using Yogurt.Infraestructure.Repositories.BaseRepository;

namespace Yogurt.Infraestructure.Repositories
{
    public class FriendRepository : RepositoryBase<ConnectEntity>, IFriendRepository
    {
        public FriendRepository(YogurtContext context) : base(context)
        {

        }

        //public Task<List<object?>> GetFriends(Guid idProfile)
        //{
        //    var query =          (  from C in YogurtContext.Conectar
        //                         join A in YogurtContext.Amizade on C.IdAmizade equals A.Id
        //                         where C.IdPerfil == idProfile ||
        //                               A.IdPerfil == idProfile
        //                         select new
        //                         {
        //                             C.
        //                         }).ToList();


        //    return query;
        //}
    }
}
