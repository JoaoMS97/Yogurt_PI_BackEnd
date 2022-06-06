using Yogurt.Application.Dto;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Interfaces;

namespace Yogurt.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _usuarioRepository;

        public UserService(IUserRepository repository)
        {
            _usuarioRepository = repository;
        }

        public async Task<ReturnDto> Login(string? email, string? senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                return new ReturnDto("Informe o email e a senha para logar no site",
                    (int)StatusCodeEnum.Return.BadRequest);
            }

            var result = await _usuarioRepository.GetByEmail(email);

            if (result == null)
            {
                return new ReturnDto("Login ou senha inválidos!", (int)StatusCodeEnum.Return.NotFound);
            }

            return Utils.Utils.RetornarHash(senha) != result.Password
                ? new ReturnDto("Login ou senha inválidos!", (int)StatusCodeEnum.Return.BadRequest)
                : new ReturnDto("Logado com Sucesso!", (int)StatusCodeEnum.Return.Sucess);
        }

        public async Task<ReturnDto> SendToken(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return new ReturnDto("Os campos Email e Senha não podem ser nulos.", (int)StatusCodeEnum.Return.BadRequest);
            }

            var result = await _usuarioRepository.GetByEmail(email);

            if (result == null)
            {
                return new ReturnDto("Email inválido!", (int)StatusCodeEnum.Return.NotFound);
            }

            string token = Utils.Utils.GenerateToken(email);

            _usuarioRepository.UpdateToken(token, result);

            return new ReturnDto(SendEmaill.SendEmail(result, token), (int)StatusCodeEnum.Return.Sucess);
        }

        public async Task<ReturnDto> Register(string email, string password, string userName, string telefone)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(telefone))
            {
                return new ReturnDto("Os campos Email, Senha, UserName e Telefone não podem ser nulos.",
                    (int)StatusCodeEnum.Return.NotFound); 
            }

            if(password.Length < 8)
            {
                return new ReturnDto("A senha não pode conter menos de 8 caractéres.", (int)StatusCodeEnum.Return.BadRequest);
            }

            if (!Utils.Utils.VerificarEmail(email))
            {
                return new ReturnDto("O email informado é invalido! por favor, informe um email válido.",
                    (int)StatusCodeEnum.Return.NotFound);
            }

            await _usuarioRepository.Insert(new UserEntity(email, Utils.Utils.RetornarHash(password), userName, telefone));

            return new ReturnDto("Sucesso", (int)StatusCodeEnum.Return.Sucess);
        }

        public async Task<ReturnDto> VerifyToken(string token, string password)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(password))
            {
                return new ReturnDto("Os campos informados senha e token não pode ser nulo.", (int)StatusCodeEnum.Return.NotFound);
            }

            if (password.Length < 8)
            {
                return new ReturnDto("A senha não pode conter menos de 8 caractéres.", (int)StatusCodeEnum.Return.BadRequest);
            }

            var result = await _usuarioRepository.GetByToken(token);

            if (result == null)
            {
                return new ReturnDto("O token informado é inválido!", (int)StatusCodeEnum.Return.NotFound);
            }

            if (result.Password == Utils.Utils.RetornarHash(password))
            {
                return new ReturnDto("A nova senha não pode ser igual a senha atual.", (int)StatusCodeEnum.Return.BadRequest);
            }

            _usuarioRepository.UpdatePassword(Utils.Utils.RetornarHash(password), result);
            _usuarioRepository.UpdateToken("", result);

            return new ReturnDto("Sucesso!", (int)StatusCodeEnum.Return.Sucess);
        }
    }
}
