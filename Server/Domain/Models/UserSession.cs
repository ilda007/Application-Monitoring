namespace Domain.Models
{
  using System;

  /// <summary>
  /// User session class.
  /// </summary>
  public class UserSession : Entity
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="UserSession"/> class.
    /// </summary>
    /// <param name="sessionBegin">Session begin.</param>
    public UserSession(DateTime sessionBegin)
    {
      this.SessionBegin = sessionBegin;
    }

    /// <summary>
    /// Gets or sets user open session.
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Gets or sets session begin.
    /// </summary>
    public DateTime SessionBegin { get; set; }

    /// <summary>
    /// Gets or sets session end.
    /// </summary>
    public DateTime? SessionEnd { get; set; }
  }
}
