using InformeAquiAPI.Domain.Core.Enum;
using InformeAquiAPI.Domain.Core.ValueObject;
using InformeAquiAPI.Domain.Erros;
using InformeAquiAPI.Infrastructure.Shared.Dtos;

namespace InformeAquiAPI.Infrastructure.Shared.Mapper
{
    public static class MapperApplication
    {

        public static InformeProblemas MapperBusiness(InformeProblemasDTO informeProblemas)
        {
            return new InformeProblemas
            {
                Ocorrencia = informeProblemas.Ocorrencia,
                Bairro = informeProblemas.Bairro,
                Email = informeProblemas.Email,
                Rua = informeProblemas.Rua,
                Nome = informeProblemas.Nome,
                TiposProblemas = ConvertTiposProblemas(informeProblemas.TiposProblemas)
            };
        }

        private static TiposProblemas ConvertTiposProblemas(string tiposProblemas)
        {
            var result = tiposProblemas switch
            {
                "ANIMAL" => TiposProblemas.ANIMAL,
                "SANITARIO" => TiposProblemas.SANITARIO,
                "BURACOS" => TiposProblemas.BURACOS,
                "POLUICAO_SONORA" => TiposProblemas.POLUICAO_SONORA,
                _ => throw new BusinessException("TIPOS NÃO ENCONTRADO.")
            };

            return result;
        }
    }
}
