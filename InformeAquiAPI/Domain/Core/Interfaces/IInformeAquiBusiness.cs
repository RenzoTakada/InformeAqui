using InformeAquiAPI.Domain.Core.ValueObject;


namespace InformeAquiAPI.Domain.Core.Interfaces
{
    public interface IInformeAquiBusiness
    {
        Task<bool> RegistraProblemaAsync(InformeProblemas mensagem);
    }
}
