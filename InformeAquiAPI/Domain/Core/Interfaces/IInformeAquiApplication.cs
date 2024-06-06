using InformeAquiAPI.Infrastructure.Shared.Dtos;

namespace InformeAquiAPI.Domain.Core.Interfaces
{
    public interface IInformeAquiApplication
    {
        Task<bool> RegistraProblemaAsync(InformeProblemasDTO mensagem);
    }
}
