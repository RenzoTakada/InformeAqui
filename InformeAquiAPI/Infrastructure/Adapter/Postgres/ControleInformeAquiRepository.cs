using Dapper;
using InformeAquiAPI.Domain.Core.Interfaces;
using InformeAquiAPI.Domain.Core.ValueObject;
using Npgsql;

namespace InformeAquiAPI.Infrastructure.Adapter.Postgres
{
    public class ControleInformeAquiRepository : IControleInformeAquiRepository
    {
        private readonly string _connectString;
        public ControleInformeAquiRepository(IConfiguration configuration)
        {
            _connectString = configuration.GetConnectionString("postgres");
        }
        public async Task<bool> RegistraProblemaAsync(InformeProblemas mensagem)
        {
            try
            {
                var controleId = Guid.NewGuid().ToString();
                using var connect = new NpgsqlConnection(_connectString);

                        var query = @"
        INSERT INTO tb_problemas_sanitarios (controleId,ocorrencia,bairro, nome, email,tipoproblema)
        VALUES (@ControleId, @Ocorrencia, @Bairro, @Nome, @Email, @tipoproblema);
        ";

                var parameters = new
                {
                    ControleId = controleId,
                    Ocorrencia = mensagem.Ocorrencia,
                    Bairro = mensagem.Bairro,
                    Nome = mensagem.Nome,
                    Email = mensagem.Email,
                    tipoproblema = mensagem.TiposProblemas
                };

                var result = await connect.ExecuteAsync(query, parameters);

                if (result > 0)
                    return true;

                return false;

            }
            catch (Exception ex) 
            {
                return false;

            }

        }
    }
}
