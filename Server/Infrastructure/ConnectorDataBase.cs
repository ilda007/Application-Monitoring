using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure
{
  public class ConnectorDataBase: DbContext
  {
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserSession> UserSessions { get; set; } = null!;

    public DbSet<Application> Applications { get; set; } = null!;

    public DbSet<Computer> Computers { get; set; } = null!;
    public DbSet<ComputerSession> ComputerSessions { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Port=2023;Database=usersdb;Username=TestUser;Password=11111");
    }
  }
}
