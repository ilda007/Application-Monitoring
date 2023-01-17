namespace Infrastructure.Repository
{
  using Domain.Models;

  /// <summary>
  /// Computer repository class.
  /// </summary>
  public class ComputerRepository : EntityRepository<Computer>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ComputerRepository"/> class.
    /// </summary>
    /// <param name="connectorDataBase">Connection context for database.</param>
    public ComputerRepository(ConnectorDataBase connectorDataBase)
      : base(connectorDataBase)
    {
    }
  }
}
