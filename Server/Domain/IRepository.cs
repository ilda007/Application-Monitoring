namespace Domain.Repositories
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  /// <summary>
  /// Repository interface.
  /// </summary>
  /// <typeparam name="T">Generic type.</typeparam>
  public interface IRepository<T>
      where T : IEntity
  {
    /// <summary>
    /// Delegate argument.
    /// </summary>
    /// <param name="entity">Entity.</param>
    /// <returns>Result.</returns>
    public delegate bool IsEqual(T entity);

    /// <summary>
    /// Save entity in repository.
    /// </summary>
    /// <param name="entity">Entity.</param>
    void Save(T entity);

    /// <summary>
    /// Get entity from repository.
    /// </summary>
    /// <param name="id">Id entity.</param>
    /// <returns>Entity.</returns>
    T Get(int id);

    IEnumerable<T> GetAll();

    /// <summary>
    /// Get all entities from repository.
    /// </summary>
    /// <param name="func">Condition.</param>
    /// <returns>All entities.</returns>
    IEnumerable<T> GetAll(Func<T, bool> predicate);

    /// <summary>
    /// Delete entity in repository.
    /// </summary>
    /// <param name="enity">Entity.</param>
    void Delete(T enity);
  }
}
