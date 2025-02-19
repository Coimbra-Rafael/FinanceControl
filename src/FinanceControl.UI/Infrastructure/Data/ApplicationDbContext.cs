using FinanceControl.UI.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace FinanceControl.UI.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Usuarios> Usuarios { get; set; }
    public DbSet<ContasAPagar> ContasAPagar { get; set; }
    public DbSet<ContasAReceber> ContasAReceber { get; set; }
    public DbSet<ContasFinanceiras> ContasFinanceiras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}