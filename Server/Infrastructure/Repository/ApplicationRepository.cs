namespace Infrastructure.Repository
{
  using Domain.Models;

  /// <summary>
  /// Application repository class.
  /// </summary>
  public class ApplicationRepository : EntityRepository<Application>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationRepository"/> class.
    /// </summary>
    /// <param name="connectorDataBase">Connection context for database.</param>
    public ApplicationRepository(ConnectorDataBase connectorDataBase)
        : base(connectorDataBase)
    {
    }
  }
}
