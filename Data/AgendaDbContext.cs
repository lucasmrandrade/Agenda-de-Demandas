using Microsoft.EntityFrameworkCore;

namespace AgendamentoDemandas.Data;
public class AgendaDbContext : DbContext
{
    public AgendaDbContext(
        DbContextOptions<AgendaDbContext> options)
        : base(options)
    {
    }

    public DbSet<Demanda> Demandas => Set<Demanda>();
}