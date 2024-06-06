using InformeAquiAPI.Domain.Core.Interfaces;
using InformeAquiAPI.Domain.Erros;
using InformeAquiAPI.Infrastructure.Shared.Dtos;
using InformeAquiAPI.Infrastructure.Shared.Mapper;

namespace InformeAquiAPI.Domain.Application
{
    public class InformeAquiApplication : IInformeAquiApplication
    {
        private readonly IInformeAquiBusiness _informeAquiBusiness;
        public InformeAquiApplication(IInformeAquiBusiness informeAquiBusiness)
        {
            _informeAquiBusiness = informeAquiBusiness;
        }
        public async Task<bool> RegistraProblemaAsync(InformeProblemasDTO mensagem)
        {
            try
            {

                var messageBusiness = MapperApplication.MapperBusiness(mensagem);
                var result = await _informeAquiBusiness.RegistraProblemaAsync(messageBusiness);
                return result;

            }
            catch (BusinessException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
