namespace InformeAquiAPI.Domain.Erros
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) :base(message) { }
    }
}
