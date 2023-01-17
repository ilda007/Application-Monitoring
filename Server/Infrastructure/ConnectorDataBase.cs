namespace Infrastructure
{
  using Domain.Models;
  using Microsoft.EntityFrameworkCore;

  /// <summary>
  /// ConnectorDataBase class for work with database.
  /// </summary>
  public class ConnectorDataBase : DbContext
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectorDataBase"/> class.
    /// </summary>
    /// <param name="options">Options.</param>
    public ConnectorDataBase(DbContextOptions<ConnectorDataBase> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets users collection.
    /// </summary>
    public DbSet<User> Users { get; set; } = null!;

    /// <summary>
    /// Gets or sets user sessions collection.
    /// </summary>
    public DbSet<UserSession> UserSessions { get; set; } = null!;

    /// <summary>
    /// Gets or sets applications collection.
    /// </summary>
    public DbSet<Application> Applications { get; set; } = null!;

    /// <summary>
    /// Gets or sets computers collection.
    /// </summary>
    public DbSet<Computer> Computers { get; set; } = null!;

    /// <summary>
    /// Gets or sets  computer sessions collection.
    /// </summary>
    public DbSet<ComputerSession> ComputerSessions { get; set; } = null!;
  }
}
