using SiriusApi.Models;

namespace SiriusApi.Services.Notas;

public interface INotas
{
    Task<IEnumerable<NotasModel>> GetNotasAsync();
    Task<NotasModel> GetNotaAsync(int id);
    Task<NotasModel> CreateNotaAsync(NotasModel nota);
    Task<NotasModel> UpdateNotaAsync(NotasModel nota);
    Task DeleteNotaAsync(int id);
}
