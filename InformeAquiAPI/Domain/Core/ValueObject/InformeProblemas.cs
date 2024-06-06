using InformeAquiAPI.Domain.Core.Enum;

namespace InformeAquiAPI.Domain.Core.ValueObject
{
    public class InformeProblemas
    {
        public string Ocorrencia { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public TiposProblemas TiposProblemas { get; set; }
    }
}
