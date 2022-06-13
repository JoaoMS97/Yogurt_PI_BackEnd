using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Application.Dto;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Domain.Entities.User;
using Yogurt.Infraestructure.Interfaces;

namespace Yogurt.Application.Services
{
    public class RegisterService: IRegisterService
    {
        //private readonly IRegisterRepository _registerRepository;

        //public RegisterService(IRegisterRepository repository)
        //{
        //    _registerRepository = repository;
        //}

        //public async Task<ReturnDto> Register( usuario)

        //{
        //    if (string.IsNullOrEmpty() || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username) || telefone == null)
        //    {
        //        return new ReturnDto("Os campos Email, Senha, UserName e Telefone não podem ser nulos.",
        //            StatusCodeEnum.Return.NotFound);
        //    }

        //    if (username.Length < 3)
        //    {
        //        return new ReturnDto("O Username não pode conter menos de 3 caractéres.", StatusCodeEnum.Return.BadRequest);
        //    }

        //    if (password.Length < 8)
        //    {
        //        return new ReturnDto("A senha não pode conter menos de 8 caractéres.", StatusCodeEnum.Return.BadRequest);
        //    }

        //    if (!Utils.Utils.VerificarEmail(email))
        //    {
        //        return new ReturnDto("O email informado é invalido! por favor, informe um email válido.",
        //            StatusCodeEnum.Return.NotFound);
        //    }

        //    var user = await _registerRepository.InsertUser(new UserEntity(email, Utils.Utils.RetornarHash(password), $"@{username}", telefone));



        //    return new ReturnDto("Sucesso", StatusCodeEnum.Return.Sucess);
        //}
    }
}
