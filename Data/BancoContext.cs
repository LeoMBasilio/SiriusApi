using Microsoft.EntityFrameworkCore;
using SiriusApi.Models;

namespace SiriusApi.Data;

public class BancoContext : DbContext
{

    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }

    public DbSet<tarefasModel> Tarefas { get; set; }

}
