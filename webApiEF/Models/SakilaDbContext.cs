using Microsoft.EntityFrameworkCore;

namespace webApiEF.Models
{
  public class SakilaDbContext : DbContext {
    public SakilaDbContext(DbContextOptions<SakilaDbContext> options)
    : base(options) { }

    public DbSet<Ator> Ator { get; set; }
    // DbSet<T> type properties for other domain models
    }
}