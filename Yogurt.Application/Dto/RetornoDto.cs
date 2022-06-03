namespace Yogurt.Application.Dto
{
    public class RetornoDto
    {
        public string Message { get; set; }

        public int StatusCode { get; set; }

        public object? Objeto { get; set; }

        public RetornoDto(string mensagem, int statusCode)
        {
            Message = mensagem;
            StatusCode = statusCode;
        }

        public RetornoDto(string mensagem, int statusCode, object objeto)
        {
            Message = mensagem;
            StatusCode = statusCode;
            Objeto = objeto;
        }
    }
}
