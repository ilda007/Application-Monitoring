namespace Domain
{
  using System;

  /// <summary>
  /// Entity interface.
  /// </summary>
  public interface IEntity
  {
    /// <summary>
    /// Gets or sets Id entity.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Gets or sets Guid entity.
    /// </summary>
    Guid Guid { get; set; }
  }
}