using System.Collections.Generic;
using Domain;
using Domain.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
  public abstract class EntityRepository<T> : IRepository<T> where T : class, IEntity
  {
    private List<T> repository = new List<T>();

    public DbSet<T> DbSet { get; set; } = null!;

    public void Delete(T enity)
    {
      this.DbSet.Remove(enity);
    }

    public T Get(int id)
    {
      return this.repository.FirstOrDefault(t => t.Id == id);
    }

    public System.Linq.IQueryable<T> GetAll(IRepository<T>.IsEqual func = null)
    {
      return this.repository.AsQueryable();
    }

    public void Save(T entity)
    {
      using (var db = new ConnectorDataBase())
      {
        db.Set<T>().Add(entity);
        db.SaveChanges();
      }
    }
  }
}
