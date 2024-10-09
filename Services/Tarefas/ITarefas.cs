using SiriusApi.Models;

namespace SiriusApi.Services.Tarefas;

public interface ITarefas
{
    Task<IEnumerable<tarefasModel>> GetTarefas();
    Task<tarefasModel> GetTarefa(int id);
    Task<tarefasModel> AddTarefa(tarefasModel tarefa);
    Task<tarefasModel> UpdateTarefa(int id, tarefasModel tarefa);
    Task<tarefasModel> DeleteTarefa(int id);
}
