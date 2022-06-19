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
    public class FriendService: IFriendService
    {
        private readonly IFriendRepository _friendRepository;

        private readonly IProfileUserRepository _perfilRepository;

        public FriendService(IFriendRepository repositoryFriend, IProfileUserRepository repositoryProfile)
        {
            _friendRepository = repositoryFriend;
            _perfilRepository = repositoryProfile;
        }

        //public async Task<ReturnDto> InsertFriend(Guid? idPerfil, Guid? idPerfilPretendido)
        //{
        //    if (idPerfil == Guid.Empty || idPerfilPretendido == Guid.Empty)
        //    {
        //        return new ReturnDto("Um dos itens se encontra nulo", StatusCodeEnum.Return.BadRequest);
        //    }

        //    var perfilSolicitante = _perfilRepository.GetById(idPerfil.Value);

        //    if (perfilSolicitante == null)
        //    {
        //        return new ReturnDto("Perfil solicitante não existe", StatusCodeEnum.Return.NotFound);
        //    }

        //    var perfilRecebidor = _perfilRepository.GetById(idPerfilPretendido.Value);

        //    if (perfilRecebidor == null)
        //    {
        //        return new ReturnDto("Perfil pretendido não existe", StatusCodeEnum.Return.NotFound);
        //    }

            

        //    var connect = new ConnectEntity() {  };


        //    return;
        //}
    }
}
