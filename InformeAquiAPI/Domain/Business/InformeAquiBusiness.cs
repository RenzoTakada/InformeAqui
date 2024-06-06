using InformeAquiAPI.Domain.Core.Interfaces;
using InformeAquiAPI.Domain.Core.ValueObject;

namespace InformeAquiAPI.Domain.Business
{
    public class InformeAquiBusiness : IInformeAquiBusiness
    {
        private readonly IControleInformeAquiRepository _informeAquiRepository;
        public InformeAquiBusiness(IControleInformeAquiRepository informeAquiRepository)
        {
            _informeAquiRepository = informeAquiRepository;
        }
        public async Task<bool> RegistraProblemaAsync(InformeProblemas mensagem)
        {
            var resultado = await _informeAquiRepository.RegistraProblemaAsync(mensagem);

            return resultado;
        }
    }
}
