using InformeAquiAPI.Domain.Core.ValueObject;
using InformeAquiAPI.Infrastructure.Shared.Dtos;

namespace InformeAquiAPI.Domain.Core.Interfaces
{
    public interface IControleInformeAquiRepository
    {
        Task<bool> RegistraProblemaAsync(InformeProblemas mensagem);
    }
}
