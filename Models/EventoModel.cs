namespace SiriusApi.Models;

public class EventoModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public DateTime? DataFim { get; set; }
    public string Local { get; set; }
}
