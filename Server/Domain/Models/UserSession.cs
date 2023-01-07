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
    /// <param name="user">User created session.</param>
    /// <param name="sessionBegin">Session begin.</param>
    public UserSession(User user, DateTime sessionBegin)
    {
      this.User = user;
      this.SessionBegin = sessionBegin;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserSession"/> class.
    /// </summary>
    private UserSession()
    {
    }

    /// <summary>
    /// Gets user open session.
    /// </summary>
    public User User { get; }

    /// <summary>
    /// Gets session begin.
    /// </summary>
    public DateTime SessionBegin { get; }

    /// <summary>
    /// Gets or sets session end.
    /// </summary>
    public DateTime? SessionEnd { get; set; }
  }
}
