namespace Infrastructure.Repository
{
  using Domain.Models;

  /// <summary>
  /// User session repository class.
  /// </summary>
  public class UserSessionRepository : EntityRepository<UserSession>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="UserSessionRepository"/> class.
    /// </summary>
    /// <param name="connectorDataBase">Connection context for database.</param>
    public UserSessionRepository(ConnectorDataBase connectorDataBase)
      : base(connectorDataBase)
    {
    }
  }
}
