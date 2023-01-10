namespace Domain
{
  using System;

  /// <summary>
  /// Entity class.
  /// </summary>
  public abstract class Entity : IEntity
  {
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets guid.
    /// </summary>
    public Guid Guid { get; set; }
  }
}