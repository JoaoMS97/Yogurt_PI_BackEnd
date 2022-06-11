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
    public class ProfileUserService : IProfileUserService
    {
        private readonly IProfileUserRepository _profileUserRepository;

        public ProfileUserService(IProfileUserRepository repository)
        {
            _profileUserRepository = repository;
        }
        public async Task<RetornoDto> Register(string userName, string biography, DateTime dataNascimento, char genero, Guid idUsuario, byte[]? fotoPerfil)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return new RetornoDto("Preencha o UserName.", (int)StatusCodeEnum.Retorno.NotFound);
            }
            
            if (userName.Length < 3)
            {
                return new RetornoDto("O Username não pode conter menos de 3 caractéres.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if (userName.Length > 50)
            {
                return new RetornoDto("O nome não pode conter mais de 50 caractéres", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if (biography.Length > 4000)
            {
                return new RetornoDto("Quantidade de caractéres superior ao permitido", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            //if (dataNascimento == )
            //{
            //    return new RetornoDto("Preencha a dataNascimento.", (int)StatusCodeEnum.Retorno.BadRequest);
            //}

            if (dataNascimento > DateTime.Today)
            {
                return new RetornoDto("A Data de Nascimento não pode ser superior a data atual.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if(dataNascimento < new DateTime(1899/12/31))
            {
                return new RetornoDto("A Data de Nascimento não pode ser inferior ao ano de 1900.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            //if(genero == )
            //{
            //    return new RetornoDto("Preencha o gênero.", (int)StatusCodeEnum.Retorno.NotFound);
            //}

            if(genero != 'F' || genero != 'M')
            {
                return new RetornoDto("Inicial de gênero incorreta.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            await _profileUserRepository.Insert(new ProfileUserEntity(idUsuario, userName, dataNascimento, fotoPerfil, biography, genero));

            return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);

        }

        public async Task<RetornoDto> AlterUserName(string userName, Guid idPerfil)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return new RetornoDto("Você precisa ter um nome!", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if (userName.Length < 3)
            {
                return new RetornoDto("O nome não pode conter menos de 3 caractéres!", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if (userName.Length > 50)
            {
                return new RetornoDto("O nome não pode conter mais de 50 caractéres", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if(idPerfil == Guid.Empty)
            {
                return new RetornoDto("Id do perfil Inválido", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            var result = await _profileUserRepository.GetById(idPerfil);

            if(result == null)
            {
                return new RetornoDto("Registro não encontrado.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            _profileUserRepository.UpdateUserName(userName, result);

            return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);
        }

        public async Task<RetornoDto> AlterBiography(string? biography, Guid idPerfil)
        {
            if (biography.Length > 4000)
            {
                return new RetornoDto("Quantidade de caractéres superior ao permitido", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if (idPerfil == Guid.Empty)
            {
                return new RetornoDto("Id do perfil Inválido", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            var result = await _profileUserRepository.GetById(idPerfil);

            if (result == null)
            {
                return new RetornoDto("Registro não encontrado.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            _profileUserRepository.UpdateBiography(biography, result);

            return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);
        }

        public async Task<RetornoDto> AlterProfilePhoto(byte[]? profilePhoto, Guid idPerfil)
        {
            if (idPerfil == Guid.Empty)
            {
                return new RetornoDto("Id do perfil Inválido", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            var result = await _profileUserRepository.GetById(idPerfil);

            if (result == null)
            {
                return new RetornoDto("Registro não encontrado.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            _profileUserRepository.UpdateProfilePhoto(profilePhoto, result);

            return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);
        }

        public async Task<RetornoDto> AlterCity(string city, Guid idPerfil)
        {
            if (string.IsNullOrEmpty(city))
            {
                return new RetornoDto("Você precisa informar uma cidade!", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            if (idPerfil == Guid.Empty)
            {
                return new RetornoDto("Id do perfil Inválido", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            var result = await _profileUserRepository.GetById(idPerfil);

            if (result == null)
            {
                return new RetornoDto("Registro não encontrado.", (int)StatusCodeEnum.Retorno.BadRequest);
            }

            //_profileUserRepository.UpdateCity(city, result);

            return new RetornoDto("Sucesso", (int)StatusCodeEnum.Retorno.Sucesso);
        }
    }
}
