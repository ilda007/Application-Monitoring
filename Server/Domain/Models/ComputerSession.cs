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
    public ComputerSession(Computer computer, DateTime sessionBegin, string? note = null)
    {
      this.Computer = computer;
      this.SessionBegin = sessionBegin;
      this.Note = note;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ComputerSession"/> class.
    /// </summary>
    private ComputerSession()
    {
    }

    /// <summary>
    /// Gets computer.
    /// </summary>
    public Computer Computer { get; }

    /// <summary>
    /// Gets session begin.
    /// </summary>
    public DateTime SessionBegin { get; }

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
