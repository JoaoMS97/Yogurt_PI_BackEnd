namespace Yogurt.Application.Dto
{
    public class RetornoDto
    {
        public string Mensagem { get; set; }

        public int StatusCode { get; set; }

        public object? Objeto { get; set; }
        
        public List<object?> ListaDeObjetos { get; set; }

        public RetornoDto(string mensagem, int statusCode)
        {
            Mensagem = mensagem;
            StatusCode = statusCode;
        }

        public RetornoDto(string mensagem, int statusCode, object objeto)
        {
            Mensagem = mensagem;
            StatusCode = statusCode;
            Objeto = objeto;
        }
        
        public RetornoDto(string mensagem, int statusCode, List<object?> listaDeObjetos)
        {
            Mensagem = mensagem;
            StatusCode = statusCode;
            ListaDeObjetos = listaDeObjetos;
        }
    }
}
