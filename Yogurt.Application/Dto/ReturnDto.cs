namespace Yogurt.Application.Dto
{
    public class ReturnDto
    {
        public string Message { get; set; }

        public int StatusCode { get; set; }

        public object? Objeto { get; set; }
        
        public List<object?> ListaDeObjetos { get; set; }

        public ReturnDto(string mensagem, int statusCode)
        {
            Message = mensagem;
            StatusCode = statusCode;
        }

        public ReturnDto(string mensagem, int statusCode, object objeto)
        {
            Message = mensagem;
            StatusCode = statusCode;
            Objeto = objeto;
        }
        
        public ReturnDto(string mensagem, int statusCode, List<object?> listaDeObjetos)
        {
            Message = mensagem;
            StatusCode = statusCode;
            ListaDeObjetos = listaDeObjetos;
        }
    }
}
