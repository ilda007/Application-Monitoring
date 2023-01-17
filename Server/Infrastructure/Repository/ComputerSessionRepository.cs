namespace Infrastructure.Repository
{
  using Domain.Models;

  /// <summary>
  /// Computer session repository class.
  /// </summary>
  public class ComputerSessionRepository : EntityRepository<ComputerSession>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ComputerSessionRepository"/> class.
    /// </summary>
    /// <param name="connectorDataBase">Connection context for database.</param>
    public ComputerSessionRepository(ConnectorDataBase connectorDataBase)
      : base(connectorDataBase)
    {
    }
  }
}
