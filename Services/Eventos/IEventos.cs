using SiriusApi.Models;

namespace SiriusApi.Services.Eventos;

public interface IEventos
{
    Task<IEnumerable<EventoModel>> GetEventosAsync();
    Task<EventoModel> GetEventoAsync(int id);
    Task<EventoModel> CreateEventoAsync(EventoModel evento);
    Task<EventoModel> UpdateEventoAsync(EventoModel evento);
    Task DeleteEventoAsync(int id);
}
