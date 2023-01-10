namespace Domain.Models
{
  using System;

  /// <summary>
  /// Computer session class.
  /// </summary>
  public class ComputerSession : Entity
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ComputerSession"/> class.
    /// </summary>
    /// <param name="computer">Computer.</param>
    /// <param name="sessionBegin">Session begin.</param>
    /// <param name="note">Note.</param>
    public ComputerSession(DateTime sessionBegin, string? note = null)
    {
      this.SessionBegin = sessionBegin;
      this.Note = note;
    }

    /// <summary>
    /// Gets or sets computer.
    /// </summary>
    public Computer Computer { get; set; }

    /// <summary>
    /// Gets or sets session begin.
    /// </summary>
    public DateTime SessionBegin { get; set; }

    /// <summary>
    /// Gets or sets session end.
    /// </summary>
    public DateTime? SessionEnd { get; set; }

    /// <summary>
    /// Gets or sets session note.
    /// </summary>
    public string? Note { get; set; }
  }
}
