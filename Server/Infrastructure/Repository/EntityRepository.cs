namespace Infrastructure
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Domain;
  using Domain.Repositories;
  using Microsoft.EntityFrameworkCore;

  /// <summary>
  /// Entity repository class.
  /// </summary>
  /// <typeparam name="T">Generic type.</typeparam>
  public abstract class EntityRepository<T> : IRepository<T>
      where T : class, IEntity
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityRepository{T}"/> class.
    /// </summary>
    /// <param name="connectorDataBase">Connection for database.</param>
    public EntityRepository(ConnectorDataBase connectorDataBase)
    {
      this.ConnectorDataBase = connectorDataBase;
      this.Repository = this.ConnectorDataBase.Set<T>();
    }

    private ConnectorDataBase ConnectorDataBase { get; set; }

    /// <summary>
    /// Gets or sets entity repository.
    /// </summary>
    private DbSet<T> Repository { get; set; } = null!;

    /// <summary>
    /// Delete entity from repository.
    /// </summary>
    /// <param name="enity">Entity being deleted.</param>
    public void Delete(T enity)
    {
      this.Repository.Remove(enity);
      this.ConnectorDataBase.SaveChanges();
    }

    /// <summary>
    /// Get enity by Id.
    /// </summary>
    /// <param name="id">Entity id.</param>
    /// <returns>Entity.</returns>
    public T Get(int id)
    {
      return this.Repository.FirstOrDefault(t => t.Id == id);
    }

    /// <summary>
    /// Get all entities.
    /// </summary>
    /// <returns>Entities collection.</returns>
    public IEnumerable<T> GetAll()
    {
      return this.Repository.AsQueryable();
    }

    /// <summary>
    /// Get all entities.
    /// </summary>
    /// <param name="predicate">Delegate.</param>
    /// <returns>Entities collection.</returns>
    public IEnumerable<T> GetAll(Func<T, bool> predicate)
    {
      return this.Repository.AsQueryable().Where(predicate);
    }

    /// <summary>
    /// Save entity to repository.
    /// </summary>
    /// <param name="entity">Entity.</param>
    public void Save(T entity)
    {
      if (this.Repository.Any() && this.Repository.FirstOrDefault(e => Equals(e, entity)) is not null)
      {
        this.ConnectorDataBase.Entry(entity).State = EntityState.Modified;
        this.ConnectorDataBase.SaveChanges();
      }
      else
      {
        this.Repository.Add(entity);
      }

      this.ConnectorDataBase.SaveChanges();
    }
  }
}
