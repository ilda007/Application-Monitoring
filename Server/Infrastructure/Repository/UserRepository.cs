namespace Infrastructure.Repository
{
  using Domain.Models;

  /// <summary>
  /// User repository class.
  /// </summary>
  public class UserRepository : EntityRepository<User>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRepository"/> class.
    /// </summary>
    /// <param name="connectorDataBase">Connection context for database.</param>
    public UserRepository(ConnectorDataBase connectorDataBase)
      : base(connectorDataBase)
    {
    }
  }
}
