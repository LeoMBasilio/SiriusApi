using SiriusApi.Models;

namespace SiriusApi.Services.Eventos;

public class EventoService : IEventos
{
    public Task<EventoModel> CreateEventoAsync(EventoModel evento)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEventoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<EventoModel> GetEventoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EventoModel>> GetEventosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EventoModel> UpdateEventoAsync(EventoModel evento)
    {
        throw new NotImplementedException();
    }
}
