using Yogurt.Application.Dto;
using Yogurt.Application.Interfaces;
using Yogurt.Application.Utils;
using Yogurt.Domain.Entities;
using Yogurt.Infraestructure.Interfaces;

namespace Yogurt.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _usuarioRepository = repository;
        }

        public async Task<RetornoDto> Login(string? email, string? senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                return new RetornoDto("Informe o email e a senha para logar no site",
                    (int)StatusCodeEnum.Return.BadRequest);
            }

            var result = await _usuarioRepository.GetByEmail(email);

            if (result == null)
            {
                return new RetornoDto("Login ou senha inválidos!", (int)StatusCodeEnum.Return.NotFound);
            }

            return Utilitarios.RetornarHash(senha) != result.Password
                ? new RetornoDto("Login ou senha inválidos!", (int)StatusCodeEnum.Return.BadRequest)
                : new RetornoDto("Logado com Sucesso!", (int)StatusCodeEnum.Return.Sucesso);
        }

        public async Task<RetornoDto> SendToken(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return new RetornoDto("Os campos Email e Senha não podem ser nulos.", (int)StatusCodeEnum.Return.BadRequest);
            }

            var result = await _usuarioRepository.GetByEmail(email);

            if (result == null)
            {
                return new RetornoDto("Email inválido!", (int)StatusCodeEnum.Return.NotFound);
            }

            string token = Utilitarios.GenerateToken(email);

            _usuarioRepository.UpdateToken(token, result);

            return new RetornoDto(EnviaEmail.SendEmail(result, token), (int)StatusCodeEnum.Return.Sucesso);
        }

        public async Task<RetornoDto> Register(string email, string password, string userName, string telefone)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(telefone))
            {
                return new RetornoDto("Os campos Email, Senha, UserName e Telefone não podem ser nulos.",
                    (int)StatusCodeEnum.Return.NotFound); 
            }

            if(password.Length < 8)
            {
                return new RetornoDto("A senha não pode conter menos de 8 caractéres.", (int)StatusCodeEnum.Return.BadRequest);
            }

            if (!Utilitarios.VerificarEmail(email))
            {
                return new RetornoDto("O email informado é invalido! por favor, informe um email válido.",
                    (int)StatusCodeEnum.Return.NotFound);
            }

            await _usuarioRepository.Insert(new UsuarioEntity(email, Utilitarios.RetornarHash(password), userName, telefone));

            return new RetornoDto("Sucesso", (int)StatusCodeEnum.Return.Sucesso);
        }

        public async Task<RetornoDto> VerifyToken(string token, string password)
        {
            if (token == string.Empty || password == string.Empty)
            {
                return new RetornoDto("Os campos informados senha e token não pode ser nulo.", (int)StatusCodeEnum.Return.NotFound);
            }

            if (password.Length < 8)
            {
                return new RetornoDto("A senha não pode conter menos de 8 caractéres.", (int)StatusCodeEnum.Return.BadRequest);
            }

            var result = await _usuarioRepository.GetByToken(token);

            if (result == null)
            {
                return new RetornoDto("O token informado é inválido!", (int)StatusCodeEnum.Return.NotFound);
            }

            if (result.Password == Utilitarios.RetornarHash(password))
            {
                return new RetornoDto("A nova senha não pode ser igual a senha atual.", (int)StatusCodeEnum.Return.BadRequest);
            }

             _usuarioRepository.UpdatePassword(Utilitarios.RetornarHash(password), result);

            return new RetornoDto("Sucesso!", (int)StatusCodeEnum.Return.Sucesso);
        }
    }
}
