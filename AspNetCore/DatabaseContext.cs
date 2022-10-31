using Microsoft.EntityFrameworkCore;

namespace AspNetCore {
  public class DatabaseContext : DbContext
  {
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    { }

    public DbSet<ProjectTeam> ProjectTeams { get; set; } = null!;
  }
}