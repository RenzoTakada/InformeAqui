using InformeAquiAPI.Domain.Core.Interfaces;
using InformeAquiAPI.Infrastructure.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InformeAquiAPI.Infrastructure.Adapter.WEB
{
    public class ControllerInformeAqui : ControllerBase
    {
        private readonly IInformeAquiApplication _informeAquiApplication;
        public ControllerInformeAqui(IInformeAquiApplication informeAquiApplication)
        {
            _informeAquiApplication = informeAquiApplication;
        }

        [HttpPost("informeaqui/v1/problemas")]
        public async Task<IActionResult> RegistraProblemasAsync([FromBody]InformeProblemasDTO mensagem)
        {
            var result = await _informeAquiApplication.RegistraProblemaAsync(mensagem);

            return Ok("Criado com sucesso.");
        }


    }
}
