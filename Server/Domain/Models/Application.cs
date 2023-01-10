namespace Domain.Models
{
  /// <summary>
  /// Application class.
  /// </summary>
  public class Application : Entity
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Application"/> class.
    /// </summary>
    /// <param name="applicationType">Application type.</param>
    /// <param name="name">Application name.</param>
    /// <param name="level">Application level.</param>
    /// <param name="size">Application size.</param>
    public Application(ApplicationType applicationType, string name, int level, double size)
    {
      this.ApplicationType = applicationType;
      this.Name = name;
      this.Level = level;
      this.Size = size;
    }

    /// <summary>
    /// Gets or sets application type.
    /// </summary>
    public ApplicationType ApplicationType { get; set; }

    /// <summary>
    /// Gets or sets appication name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets appication level.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Gets or sets appication size.
    /// </summary>
    public double Size { get; set; }
  }

  /// <summary>
  /// Application types.
  /// </summary>
  public enum ApplicationType
  {
    Cryptographer,
    Worm,
  }
}
